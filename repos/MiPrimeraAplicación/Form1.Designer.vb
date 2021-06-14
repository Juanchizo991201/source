<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TbxExample = New System.Windows.Forms.TextBox()
        Me.BtnClickAquí = New System.Windows.Forms.Button()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbxExample
        '
        Me.TbxExample.Location = New System.Drawing.Point(132, 40)
        Me.TbxExample.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TbxExample.Name = "TbxExample"
        Me.TbxExample.Size = New System.Drawing.Size(287, 23)
        Me.TbxExample.TabIndex = 0
        '
        'BtnClickAquí
        '
        Me.BtnClickAquí.Location = New System.Drawing.Point(132, 95)
        Me.BtnClickAquí.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClickAquí.Name = "BtnClickAquí"
        Me.BtnClickAquí.Size = New System.Drawing.Size(286, 23)
        Me.BtnClickAquí.TabIndex = 1
        Me.BtnClickAquí.Text = "Haga Click Aquí"
        Me.BtnClickAquí.UseVisualStyleBackColor = True
        '
        'BtnAyuda
        '
        Me.BtnAyuda.Location = New System.Drawing.Point(136, 151)
        Me.BtnAyuda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(95, 26)
        Me.BtnAyuda.TabIndex = 2
        Me.BtnAyuda.Text = "Ayuda"
        Me.BtnAyuda.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(310, 153)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(108, 22)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 399)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnAyuda)
        Me.Controls.Add(Me.BtnClickAquí)
        Me.Controls.Add(Me.TbxExample)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbxExample As TextBox
    Friend WithEvents BtnContinuar As Button
    Friend WithEvents BtnClickAquí As Button
    Friend WithEvents BtnAyuda As Button
    Friend WithEvents BtnSalir As Button
End Class
