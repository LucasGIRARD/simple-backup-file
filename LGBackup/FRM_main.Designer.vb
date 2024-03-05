<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_main))
        Me.TC_main = New System.Windows.Forms.TabControl()
        Me.TP_log = New System.Windows.Forms.TabPage()
        Me.LST_log = New System.Windows.Forms.ListBox()
        Me.TP_toSave = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BTN_delete = New System.Windows.Forms.Button()
        Me.BTN_add = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LST_folder = New System.Windows.Forms.ListBox()
        Me.TP_configuration = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_SelectPath = New System.Windows.Forms.Button()
        Me.BTN_selectPathWeb = New System.Windows.Forms.Button()
        Me.BTN_manualSave = New System.Windows.Forms.Button()
        Me.CHK_web = New System.Windows.Forms.CheckBox()
        Me.TXT_path = New System.Windows.Forms.TextBox()
        Me.TXT_pathWeb = New System.Windows.Forms.TextBox()
        Me.NUM_parallelSave = New System.Windows.Forms.NumericUpDown()
        Me.NUM_interval = New System.Windows.Forms.NumericUpDown()
        Me.TIM_IntervalSauvegarde = New System.Windows.Forms.Timer(Me.components)
        Me.FBD_many = New System.Windows.Forms.FolderBrowserDialog()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TC_main.SuspendLayout()
        Me.TP_log.SuspendLayout()
        Me.TP_toSave.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TP_configuration.SuspendLayout()
        CType(Me.NUM_parallelSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUM_interval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TC_main
        '
        Me.TC_main.Controls.Add(Me.TP_log)
        Me.TC_main.Controls.Add(Me.TP_toSave)
        Me.TC_main.Controls.Add(Me.TP_configuration)
        Me.TC_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC_main.ItemSize = New System.Drawing.Size(150, 18)
        Me.TC_main.Location = New System.Drawing.Point(0, 0)
        Me.TC_main.Name = "TC_main"
        Me.TC_main.SelectedIndex = 0
        Me.TC_main.Size = New System.Drawing.Size(384, 361)
        Me.TC_main.TabIndex = 0
        '
        'TP_log
        '
        Me.TP_log.Controls.Add(Me.LST_log)
        Me.TP_log.Location = New System.Drawing.Point(4, 22)
        Me.TP_log.Name = "TP_log"
        Me.TP_log.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_log.Size = New System.Drawing.Size(376, 335)
        Me.TP_log.TabIndex = 0
        Me.TP_log.Text = "Log"
        Me.TP_log.UseVisualStyleBackColor = True
        '
        'LST_log
        '
        Me.LST_log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_log.FormattingEnabled = True
        Me.LST_log.Location = New System.Drawing.Point(3, 3)
        Me.LST_log.Name = "LST_log"
        Me.LST_log.Size = New System.Drawing.Size(370, 329)
        Me.LST_log.TabIndex = 0
        '
        'TP_toSave
        '
        Me.TP_toSave.Controls.Add(Me.Panel2)
        Me.TP_toSave.Controls.Add(Me.Panel1)
        Me.TP_toSave.Location = New System.Drawing.Point(4, 22)
        Me.TP_toSave.Name = "TP_toSave"
        Me.TP_toSave.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_toSave.Size = New System.Drawing.Size(376, 335)
        Me.TP_toSave.TabIndex = 1
        Me.TP_toSave.Text = "Eléments à sauvegarder"
        Me.TP_toSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BTN_delete)
        Me.Panel2.Controls.Add(Me.BTN_add)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(370, 34)
        Me.Panel2.TabIndex = 4
        '
        'BTN_delete
        '
        Me.BTN_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_delete.Location = New System.Drawing.Point(188, 6)
        Me.BTN_delete.Name = "BTN_delete"
        Me.BTN_delete.Size = New System.Drawing.Size(75, 23)
        Me.BTN_delete.TabIndex = 2
        Me.BTN_delete.Text = "Supprimer"
        Me.BTN_delete.UseVisualStyleBackColor = True
        '
        'BTN_add
        '
        Me.BTN_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_add.Location = New System.Drawing.Point(107, 6)
        Me.BTN_add.Name = "BTN_add"
        Me.BTN_add.Size = New System.Drawing.Size(75, 23)
        Me.BTN_add.TabIndex = 1
        Me.BTN_add.Text = "Ajouter"
        Me.BTN_add.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LST_folder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 36)
        Me.Panel1.Size = New System.Drawing.Size(370, 329)
        Me.Panel1.TabIndex = 4
        '
        'LST_folder
        '
        Me.LST_folder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_folder.FormattingEnabled = True
        Me.LST_folder.Location = New System.Drawing.Point(0, 0)
        Me.LST_folder.Name = "LST_folder"
        Me.LST_folder.Size = New System.Drawing.Size(370, 293)
        Me.LST_folder.TabIndex = 0
        '
        'TP_configuration
        '
        Me.TP_configuration.Controls.Add(Me.Label5)
        Me.TP_configuration.Controls.Add(Me.Label4)
        Me.TP_configuration.Controls.Add(Me.Label3)
        Me.TP_configuration.Controls.Add(Me.Label2)
        Me.TP_configuration.Controls.Add(Me.Label1)
        Me.TP_configuration.Controls.Add(Me.BTN_SelectPath)
        Me.TP_configuration.Controls.Add(Me.BTN_selectPathWeb)
        Me.TP_configuration.Controls.Add(Me.BTN_manualSave)
        Me.TP_configuration.Controls.Add(Me.CHK_web)
        Me.TP_configuration.Controls.Add(Me.TXT_path)
        Me.TP_configuration.Controls.Add(Me.TXT_pathWeb)
        Me.TP_configuration.Controls.Add(Me.NUM_parallelSave)
        Me.TP_configuration.Controls.Add(Me.NUM_interval)
        Me.TP_configuration.Location = New System.Drawing.Point(4, 22)
        Me.TP_configuration.Name = "TP_configuration"
        Me.TP_configuration.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_configuration.Size = New System.Drawing.Size(376, 335)
        Me.TP_configuration.TabIndex = 2
        Me.TP_configuration.Text = "Divers"
        Me.TP_configuration.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre de sauvegarde parallèle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Délai entre chaque sauvegarde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Chemin dossier de sauvegarde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dossier web"
        '
        'BTN_SelectPath
        '
        Me.BTN_SelectPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_SelectPath.Location = New System.Drawing.Point(296, 4)
        Me.BTN_SelectPath.Name = "BTN_SelectPath"
        Me.BTN_SelectPath.Size = New System.Drawing.Size(74, 23)
        Me.BTN_SelectPath.TabIndex = 3
        Me.BTN_SelectPath.Text = "Sélectionner"
        Me.BTN_SelectPath.UseVisualStyleBackColor = True
        '
        'BTN_selectPathWeb
        '
        Me.BTN_selectPathWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_selectPathWeb.Enabled = False
        Me.BTN_selectPathWeb.Location = New System.Drawing.Point(296, 32)
        Me.BTN_selectPathWeb.Name = "BTN_selectPathWeb"
        Me.BTN_selectPathWeb.Size = New System.Drawing.Size(74, 23)
        Me.BTN_selectPathWeb.TabIndex = 3
        Me.BTN_selectPathWeb.Text = "Sélectionner"
        Me.BTN_selectPathWeb.UseVisualStyleBackColor = True
        '
        'BTN_manualSave
        '
        Me.BTN_manualSave.Location = New System.Drawing.Point(172, 113)
        Me.BTN_manualSave.Name = "BTN_manualSave"
        Me.BTN_manualSave.Size = New System.Drawing.Size(120, 23)
        Me.BTN_manualSave.TabIndex = 3
        Me.BTN_manualSave.Text = "Sauvegarde manuel"
        Me.BTN_manualSave.UseVisualStyleBackColor = True
        '
        'CHK_web
        '
        Me.CHK_web.AutoSize = True
        Me.CHK_web.Location = New System.Drawing.Point(172, 37)
        Me.CHK_web.Name = "CHK_web"
        Me.CHK_web.Size = New System.Drawing.Size(15, 14)
        Me.CHK_web.TabIndex = 2
        Me.CHK_web.UseVisualStyleBackColor = True
        '
        'TXT_path
        '
        Me.TXT_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_path.Location = New System.Drawing.Point(172, 6)
        Me.TXT_path.Name = "TXT_path"
        Me.TXT_path.Size = New System.Drawing.Size(120, 20)
        Me.TXT_path.TabIndex = 1
        '
        'TXT_pathWeb
        '
        Me.TXT_pathWeb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_pathWeb.Enabled = False
        Me.TXT_pathWeb.Location = New System.Drawing.Point(193, 34)
        Me.TXT_pathWeb.Name = "TXT_pathWeb"
        Me.TXT_pathWeb.Size = New System.Drawing.Size(97, 20)
        Me.TXT_pathWeb.TabIndex = 1
        '
        'NUM_parallelSave
        '
        Me.NUM_parallelSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUM_parallelSave.Location = New System.Drawing.Point(172, 87)
        Me.NUM_parallelSave.Name = "NUM_parallelSave"
        Me.NUM_parallelSave.Size = New System.Drawing.Size(120, 20)
        Me.NUM_parallelSave.TabIndex = 0
        '
        'NUM_interval
        '
        Me.NUM_interval.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NUM_interval.Location = New System.Drawing.Point(172, 61)
        Me.NUM_interval.Name = "NUM_interval"
        Me.NUM_interval.Size = New System.Drawing.Size(120, 20)
        Me.NUM_interval.TabIndex = 0
        Me.NUM_interval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TIM_IntervalSauvegarde
        '
        Me.TIM_IntervalSauvegarde.Interval = 3600000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "en heure(s)"
        '
        'FRM_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.TC_main)
        Me.Name = "FRM_main"
        Me.Text = "LGBackup"
        Me.TC_main.ResumeLayout(False)
        Me.TP_log.ResumeLayout(False)
        Me.TP_toSave.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TP_configuration.ResumeLayout(False)
        Me.TP_configuration.PerformLayout()
        CType(Me.NUM_parallelSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUM_interval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TC_main As TabControl
    Friend WithEvents TP_log As TabPage
    Friend WithEvents LST_log As ListBox
    Friend WithEvents TP_toSave As TabPage
    Friend WithEvents LST_folder As ListBox
    Friend WithEvents BTN_delete As Button
    Friend WithEvents BTN_add As Button
    Friend WithEvents TP_configuration As TabPage
    Friend WithEvents BTN_manualSave As Button
    Friend WithEvents CHK_web As CheckBox
    Friend WithEvents TXT_pathWeb As TextBox
    Friend WithEvents NUM_parallelSave As NumericUpDown
    Friend WithEvents NUM_interval As NumericUpDown
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_SelectPath As Button
    Friend WithEvents BTN_selectPathWeb As Button
    Friend WithEvents TXT_path As TextBox
    Friend WithEvents TIM_IntervalSauvegarde As Timer
    Friend WithEvents FBD_many As FolderBrowserDialog
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
End Class
