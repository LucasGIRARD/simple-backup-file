Imports System.IO

Public Class FRM_main
    Const pathFileConfiguration = "LGB.ini"
    Const pathFileLog = "LGB.log"

    Const keySavePath As String = "savePath"
    Const keySaveWeb As String = "saveWeb"
    Const keySaveWebPath As String = "saveWebPath"
    Const keyInterval As String = "interval"
    Const keyParallelSaves As String = "parallelSaves"
    Const keyPaths As String = "path_"

    Dim nbrParallelSaves As Integer = 0
    Dim isSaving As Boolean = False
    Dim configurationModified As Boolean = False
    Dim started As Boolean = False
    Dim toHide As Boolean = True

    Private Sub FRM_main_Load(sender As Object, e As EventArgs) Handles Me.Load

        readIni()
        readLog()
        started = True
    End Sub

    Private Sub writeIni()
        Dim i As Integer = 1
        Dim fileLines As New List(Of String)

        fileLines.Add("[configuration]")
        fileLines.Add(keySavePath & "=" & TXT_path.Text)
        fileLines.Add(keySaveWeb & "=" & CHK_web.Checked)
        fileLines.Add(keySaveWebPath & "=" & TXT_pathWeb.Text)
        fileLines.Add(keyInterval & "=" & NUM_interval.Value)
        fileLines.Add(keyParallelSaves & "=" & NUM_parallelSave.Value)
        fileLines.Add("")
        fileLines.Add("[paths]")

        For Each path As String In LST_folder.Items
            fileLines.Add(keyPaths & i & "=" & path)
            i += 1
        Next

        File.WriteAllLines(pathFileConfiguration, fileLines)
    End Sub

    Private Sub readIni()
        Dim tempKey, tempValue As String
        Dim splittedLine As String()
        Dim t As Integer

        If File.Exists(pathFileConfiguration) Then
            For Each ligne As String In File.ReadAllLines(pathFileConfiguration)
                If ligne <> "" Then
                    splittedLine = ligne.Split("=")
                    tempKey = splittedLine(0)
                    If tempKey(0) <> "[" And tempKey(0) <> ";" Then
                        tempValue = splittedLine(1)
                        Select Case tempKey
                            Case keySavePath
                                TXT_path.Text = tempValue
                            Case keySaveWeb
                                CHK_web.Checked = tempValue
                            Case keySaveWebPath
                                TXT_pathWeb.Text = tempValue
                            Case keyInterval
                                NUM_interval.Value = tempValue
                                TIM_IntervalSauvegarde.Enabled = True
                            Case keyParallelSaves
                                NUM_parallelSave.Value = tempValue
                                nbrParallelSaves = tempValue
                            Case Else
                                t = tempKey.IndexOf(keyPaths)
                                If t >= 0 Then
                                    LST_folder.Items.Add(tempValue)
                                End If
                        End Select
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub BTN_add_Click(sender As Object, e As EventArgs) Handles BTN_add.Click

        If FBD_many.ShowDialog Then
            LST_folder.Items.Add(FBD_many.SelectedPath)
        End If
    End Sub

    Private Sub BTN_delete_Click(sender As Object, e As EventArgs) Handles BTN_delete.Click
        Dim index As Integer = LST_folder.SelectedIndex

        If index >= 0 Then
            LST_folder.Items.RemoveAt(index)
            configurationModified = True
        End If
    End Sub

    Private Sub BTN_SelectPath_Click(sender As Object, e As EventArgs) Handles BTN_SelectPath.Click

        If FBD_many.ShowDialog Then
            TXT_path.Text = FBD_many.SelectedPath
        End If
    End Sub

    Private Sub BTN_selectPathWeb_Click(sender As Object, e As EventArgs) Handles BTN_selectPathWeb.Click

        If FBD_many.ShowDialog Then
            TXT_pathWeb.Text = FBD_many.SelectedPath
        End If
    End Sub

    Private Sub CHK_web_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_web.CheckedChanged
        Dim isChecked As Boolean = CHK_web.Checked

        TXT_pathWeb.Enabled = isChecked
        BTN_selectPathWeb.Enabled = isChecked
        If started Then
            configurationModified = True
        End If
    End Sub

    Private Sub NUM_interval_ValueChanged(sender As Object, e As EventArgs) Handles NUM_interval.ValueChanged
        '3600000 = 1 hour
        TIM_IntervalSauvegarde.Interval = NUM_interval.Value * 3600000
        If started Then
            configurationModified = True
        End If
    End Sub

    Private Sub IntervalSauvegarde_Tick(sender As Object, e As EventArgs) Handles TIM_IntervalSauvegarde.Tick

        save()
    End Sub

    Private Sub BTN_manualSave_Click(sender As Object, e As EventArgs) Handles BTN_manualSave.Click

        save()
    End Sub

    Private Sub clean()
        'yyyy-MM-dd_HH-mm
        Dim regex = New System.Text.RegularExpressions.Regex("[0-9]{4}-[0-9]{2}-[0-9]{2}_[0-9]{2}-[0-9]{2}-[0-9]{2}")

        If Directory.Exists(TXT_path.Text) Then
            Dim directoriesLocal As String() = Array.FindAll(Directory.GetDirectories(TXT_path.Text), Function(x) regex.IsMatch(x))
            Dim nbrToDeleteLocal As Integer = directoriesLocal.Count - NUM_parallelSave.Value
            Dim directorieToDeleteLocal As DirectoryInfo

            If NUM_parallelSave.Value <> 0 And nbrToDeleteLocal > 0 Then
                Array.Sort(directoriesLocal)

                For i = 0 To nbrToDeleteLocal - 1
                    directorieToDeleteLocal = New DirectoryInfo(directoriesLocal(i))

                    directorieToDeleteLocal.Delete(True)
                Next

            End If
        End If

        If Directory.Exists(TXT_pathWeb.Text) Then
            Dim directories As String() = Array.FindAll(Directory.GetDirectories(TXT_pathWeb.Text), Function(x) regex.IsMatch(x))
            Dim nbrToDelete As Integer = directories.Count - NUM_parallelSave.Value
            Dim directorieToDelete As DirectoryInfo

            If NUM_parallelSave.Value <> 0 And nbrToDelete > 0 Then
                Array.Sort(directories)

                For i = 0 To nbrToDelete - 1
                    directorieToDelete = New DirectoryInfo(directories(i))

                    directorieToDelete.Delete(True)
                Next

            End If
        End If
    End Sub

    Private Sub save()
        Dim folderName As String = Date.Now.ToString("yyyy-MM-dd_HH-mm-ss")

        Dim pathFolder As String = TXT_path.Text & "\" & folderName
        Dim pathFolderWeb As String = TXT_pathWeb.Text & "\" & folderName

        If Not isSaving Then

            isSaving = True


            LST_log.Items.Add("Début de sauvegarde le " & Date.Now.ToString("dd/MM/yyyy à HH:mm:ss"))

            If Directory.Exists(TXT_path.Text) Then

                Directory.CreateDirectory(pathFolder)
                For Each PathASave As String In LST_folder.Items
                    If Directory.Exists(PathASave) Then
                        CopieDossier(New DirectoryInfo(PathASave), New DirectoryInfo(pathFolder & "\" & Path.GetFileName(PathASave)))
                        LST_log.Items.Add("Sauvegarde du dossier : " & Path.GetFileName(PathASave))
                    End If
                Next

                clean()

            Else
                LST_log.Items.Add("Sauvegarde échouée : le chemin de stockage de la sauvegarde est invalide, veuillez le redéfinir.")
            End If

            If CHK_web.Checked And Directory.Exists(TXT_pathWeb.Text) Then

                Directory.CreateDirectory(pathFolderWeb)
                For Each PathASave As String In LST_folder.Items
                    If Directory.Exists(PathASave) Then
                        CopieDossier(New DirectoryInfo(PathASave), New DirectoryInfo(pathFolderWeb & "\" & Path.GetFileName(PathASave)))
                        LST_log.Items.Add("Sauvegarde web du dossier : " & Path.GetFileName(PathASave))
                    End If
                Next

                clean()

            Else
                LST_log.Items.Add("Sauvegarde échouée : le chemin de stockage de la sauvegarde web est invalide, veuillez le redéfinir.")
            End If

            LST_log.Items.Add("Fin de sauvegarde le " & Date.Now.ToString("dd/MM/yyyy à HH:mm:ss"))

            isSaving = False
        End If
    End Sub

    Sub CopieDossier(ByVal DossierSource As DirectoryInfo, ByVal DossierDesination As DirectoryInfo)

        'Crée le dossier
        DossierDesination.Create()

        'Copie les fichiers
        For Each Fichier As FileInfo In DossierSource.GetFiles()
            Fichier.CopyTo(Path.Combine(DossierDesination.FullName, Fichier.Name))
        Next

        'Recommence pour les sous-répertoires
        For Each SousRepertoire As DirectoryInfo In DossierSource.GetDirectories()
            CopieDossier(SousRepertoire, DossierDesination.CreateSubdirectory(SousRepertoire.Name))
        Next
    End Sub

    Private Sub TP_configuration_Leave(sender As Object, e As EventArgs) Handles TP_configuration.Leave

        If configurationModified Then
            writeIni()
            clean()
            configurationModified = False
        End If
    End Sub

    Private Sub TP_toSave_Leave(sender As Object, e As EventArgs) Handles TP_toSave.Leave

        If configurationModified Then
            writeIni()
            configurationModified = False
        End If
    End Sub

    Private Sub TXT_path_TextChanged(sender As Object, e As EventArgs) Handles TXT_path.TextChanged

        If started Then
            configurationModified = True
        End If
    End Sub

    Private Sub TXT_pathWeb_TextChanged(sender As Object, e As EventArgs) Handles TXT_pathWeb.TextChanged

        If started Then
            configurationModified = True
        End If
    End Sub

    Private Sub NUM_parallelSave_ValueChanged(sender As Object, e As EventArgs) Handles NUM_parallelSave.ValueChanged

        If started Then
            configurationModified = True
        End If
    End Sub

    Private Sub writeLog()
        Dim lines As New List(Of String)

        For Each item As String In LST_log.Items
            lines.Add(item)
        Next

        File.WriteAllLines(pathFileLog, lines)
    End Sub

    Private Sub readLog()
        If File.Exists(pathFileLog) Then
            For Each ligne As String In File.ReadAllLines(pathFileLog)
                If ligne <> "" Then
                    LST_log.Items.Add(ligne)
                End If
            Next
        End If
    End Sub

    Private Sub FRM_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If toHide Then
            e.Cancel = True
            Me.Hide()
        Else
            writeLog()
            If configurationModified Then
                writeIni()
            End If
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        toHide = False
        Me.Close()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class