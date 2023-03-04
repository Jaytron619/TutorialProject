<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navigator
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
        Me.btnDatetimePicker = New System.Windows.Forms.Button()
        Me.btnWageCalculator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDatetimePicker
        '
        Me.btnDatetimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatetimePicker.Location = New System.Drawing.Point(36, 159)
        Me.btnDatetimePicker.Name = "btnDatetimePicker"
        Me.btnDatetimePicker.Size = New System.Drawing.Size(130, 41)
        Me.btnDatetimePicker.TabIndex = 0
        Me.btnDatetimePicker.Text = "DateTimePicker"
        Me.btnDatetimePicker.UseVisualStyleBackColor = True
        '
        'btnWageCalculator
        '
        Me.btnWageCalculator.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWageCalculator.Location = New System.Drawing.Point(190, 159)
        Me.btnWageCalculator.Name = "btnWageCalculator"
        Me.btnWageCalculator.Size = New System.Drawing.Size(142, 40)
        Me.btnWageCalculator.TabIndex = 1
        Me.btnWageCalculator.Text = "Wage Calculator"
        Me.btnWageCalculator.UseVisualStyleBackColor = True
        '
        'Navigator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 323)
        Me.Controls.Add(Me.btnWageCalculator)
        Me.Controls.Add(Me.btnDatetimePicker)
        Me.Name = "Navigator"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDatetimePicker As Button
    Friend WithEvents btnWageCalculator As Button
End Class
