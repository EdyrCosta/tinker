<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.tlsFerramentas = New System.Windows.Forms.ToolStrip()
        Me.tsbCadastrar = New System.Windows.Forms.ToolStripButton()
        Me.EditarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ExcluirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.tlsFerramentas.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlsFerramentas
        '
        Me.tlsFerramentas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCadastrar, Me.EditarToolStripButton, Me.ExcluirToolStripButton})
        Me.tlsFerramentas.Location = New System.Drawing.Point(0, 0)
        Me.tlsFerramentas.Name = "tlsFerramentas"
        Me.tlsFerramentas.Size = New System.Drawing.Size(505, 36)
        Me.tlsFerramentas.TabIndex = 0
        '
        'tsbCadastrar
        '
        Me.tsbCadastrar.Image = CType(resources.GetObject("tsbCadastrar.Image"), System.Drawing.Image)
        Me.tsbCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCadastrar.Name = "tsbCadastrar"
        Me.tsbCadastrar.Size = New System.Drawing.Size(55, 33)
        Me.tsbCadastrar.Text = "Adicionar"
        Me.tsbCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'EditarToolStripButton
        '
        Me.EditarToolStripButton.Enabled = False
        Me.EditarToolStripButton.Image = CType(resources.GetObject("EditarToolStripButton.Image"), System.Drawing.Image)
        Me.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditarToolStripButton.Name = "EditarToolStripButton"
        Me.EditarToolStripButton.Size = New System.Drawing.Size(39, 33)
        Me.EditarToolStripButton.Text = "Editar"
        Me.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExcluirToolStripButton
        '
        Me.ExcluirToolStripButton.Enabled = False
        Me.ExcluirToolStripButton.Image = CType(resources.GetObject("ExcluirToolStripButton.Image"), System.Drawing.Image)
        Me.ExcluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExcluirToolStripButton.Name = "ExcluirToolStripButton"
        Me.ExcluirToolStripButton.Size = New System.Drawing.Size(42, 33)
        Me.ExcluirToolStripButton.Text = "Excluir"
        Me.ExcluirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AllowUserToOrderColumns = True
        Me.dgvClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(0, 40)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.Size = New System.Drawing.Size(505, 339)
        Me.dgvClientes.TabIndex = 1
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 380)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.tlsFerramentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes"
        Me.tlsFerramentas.ResumeLayout(False)
        Me.tlsFerramentas.PerformLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tlsFerramentas As System.Windows.Forms.ToolStrip
    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents tsbCadastrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditarToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExcluirToolStripButton As System.Windows.Forms.ToolStripButton
End Class
