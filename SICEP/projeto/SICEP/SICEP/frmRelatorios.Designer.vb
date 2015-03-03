<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelatorios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorios))
        Me.crvVisualizador = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvVisualizador
        '
        Me.crvVisualizador.ActiveViewIndex = -1
        Me.crvVisualizador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvVisualizador.DisplayGroupTree = False
        Me.crvVisualizador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvVisualizador.Location = New System.Drawing.Point(0, 0)
        Me.crvVisualizador.Name = "crvVisualizador"
        Me.crvVisualizador.SelectionFormula = ""
        Me.crvVisualizador.Size = New System.Drawing.Size(303, 273)
        Me.crvVisualizador.TabIndex = 0
        Me.crvVisualizador.ViewTimeSelectionFormula = ""
        '
        'frmRelatorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(303, 273)
        Me.Controls.Add(Me.crvVisualizador)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelatorios"
        Me.Text = "Sistema de Relatórios do SICEP 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvVisualizador As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
