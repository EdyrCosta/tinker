<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stsStatus = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslSeparator1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslSeparator2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sslData = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrTempo = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmCascataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalmenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizoltalmenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout()
        Me.stsStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.ToolStripMenuItem1, Me.AjudaToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(632, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ToolStripSeparator1, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.AjudaToolStripMenuItem.Text = "A&juda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre..."
        '
        'stsStatus
        '
        Me.stsStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus, Me.sslSeparator1, Me.sslHora, Me.sslSeparator2, Me.sslData})
        Me.stsStatus.Location = New System.Drawing.Point(0, 431)
        Me.stsStatus.Name = "stsStatus"
        Me.stsStatus.Size = New System.Drawing.Size(632, 22)
        Me.stsStatus.TabIndex = 1
        Me.stsStatus.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(38, 17)
        Me.sslStatus.Text = "Status"
        '
        'sslSeparator1
        '
        Me.sslSeparator1.Name = "sslSeparator1"
        Me.sslSeparator1.Size = New System.Drawing.Size(11, 17)
        Me.sslSeparator1.Text = "|"
        '
        'sslHora
        '
        Me.sslHora.Name = "sslHora"
        Me.sslHora.Size = New System.Drawing.Size(142, 17)
        Me.sslHora.Text = "Obtendo Hora do Sistema..."
        '
        'sslSeparator2
        '
        Me.sslSeparator2.Name = "sslSeparator2"
        Me.sslSeparator2.Size = New System.Drawing.Size(11, 17)
        Me.sslSeparator2.Text = "|"
        '
        'sslData
        '
        Me.sslData.Name = "sslData"
        Me.sslData.Size = New System.Drawing.Size(142, 17)
        Me.sslData.Text = "Obtendo Data do Sistema..."
        '
        'tmrTempo
        '
        Me.tmrTempo.Enabled = True
        Me.tmrTempo.Interval = 1000
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmCascataToolStripMenuItem, Me.VerticalmenteToolStripMenuItem, Me.HorizoltalmenteToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.ToolStripMenuItem1.Text = "&Janelas"
        '
        'EmCascataToolStripMenuItem
        '
        Me.EmCascataToolStripMenuItem.Name = "EmCascataToolStripMenuItem"
        Me.EmCascataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmCascataToolStripMenuItem.Text = "&Em Cascata"
        '
        'VerticalmenteToolStripMenuItem
        '
        Me.VerticalmenteToolStripMenuItem.Name = "VerticalmenteToolStripMenuItem"
        Me.VerticalmenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerticalmenteToolStripMenuItem.Text = "Verticalmente"
        '
        'HorizoltalmenteToolStripMenuItem
        '
        Me.HorizoltalmenteToolStripMenuItem.Name = "HorizoltalmenteToolStripMenuItem"
        Me.HorizoltalmenteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HorizoltalmenteToolStripMenuItem.Text = "Horizontalmente"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.stsStatus)
        Me.Controls.Add(Me.mnuMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmMain"
        Me.Text = "Tinker"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.stsStatus.ResumeLayout(False)
        Me.stsStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrTempo As System.Windows.Forms.Timer
    Friend WithEvents sslHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslSeparator1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslData As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sslSeparator2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmCascataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalmenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizoltalmenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
