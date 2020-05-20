<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VBMailOrderForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerRelationsButton = New System.Windows.Forms.Button()
        Me.MarketingButton = New System.Windows.Forms.Button()
        Me.OrderProcessingButton = New System.Windows.Forms.Button()
        Me.ShippingButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DepartementContactLabel = New System.Windows.Forms.Label()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.DepartmentContactTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programmed by Lorenzo Quiroga"
        '
        'CustomerRelationsButton
        '
        Me.CustomerRelationsButton.Location = New System.Drawing.Point(38, 24)
        Me.CustomerRelationsButton.Name = "CustomerRelationsButton"
        Me.CustomerRelationsButton.Size = New System.Drawing.Size(158, 32)
        Me.CustomerRelationsButton.TabIndex = 1
        Me.CustomerRelationsButton.Text = "Customer Relations"
        Me.CustomerRelationsButton.UseVisualStyleBackColor = True
        '
        'MarketingButton
        '
        Me.MarketingButton.Location = New System.Drawing.Point(38, 82)
        Me.MarketingButton.Name = "MarketingButton"
        Me.MarketingButton.Size = New System.Drawing.Size(158, 32)
        Me.MarketingButton.TabIndex = 2
        Me.MarketingButton.Text = "Marketing"
        Me.MarketingButton.UseVisualStyleBackColor = True
        '
        'OrderProcessingButton
        '
        Me.OrderProcessingButton.Location = New System.Drawing.Point(38, 145)
        Me.OrderProcessingButton.Name = "OrderProcessingButton"
        Me.OrderProcessingButton.Size = New System.Drawing.Size(158, 32)
        Me.OrderProcessingButton.TabIndex = 3
        Me.OrderProcessingButton.Text = "Order Processing"
        Me.OrderProcessingButton.UseVisualStyleBackColor = True
        '
        'ShippingButton
        '
        Me.ShippingButton.Location = New System.Drawing.Point(38, 207)
        Me.ShippingButton.Name = "ShippingButton"
        Me.ShippingButton.Size = New System.Drawing.Size(158, 32)
        Me.ShippingButton.TabIndex = 4
        Me.ShippingButton.Text = "Shipping"
        Me.ShippingButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(38, 305)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(158, 32)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DepartementContactLabel
        '
        Me.DepartementContactLabel.AutoSize = True
        Me.DepartementContactLabel.Location = New System.Drawing.Point(252, 24)
        Me.DepartementContactLabel.Name = "DepartementContactLabel"
        Me.DepartementContactLabel.Size = New System.Drawing.Size(105, 13)
        Me.DepartementContactLabel.TabIndex = 6
        Me.DepartementContactLabel.Text = "Department Contact:"
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.AutoSize = True
        Me.PhoneNumberLabel.CausesValidation = False
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(252, 145)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(81, 13)
        Me.PhoneNumberLabel.TabIndex = 7
        Me.PhoneNumberLabel.Text = "Phone Number:"
        '
        'DepartmentContactTextBox
        '
        Me.DepartmentContactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentContactTextBox.Location = New System.Drawing.Point(252, 47)
        Me.DepartmentContactTextBox.Name = "DepartmentContactTextBox"
        Me.DepartmentContactTextBox.Size = New System.Drawing.Size(145, 22)
        Me.DepartmentContactTextBox.TabIndex = 8
        Me.DepartmentContactTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(254, 166)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(142, 22)
        Me.PhoneNumberTextBox.TabIndex = 9
        Me.PhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'VBMailOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 356)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(Me.DepartmentContactTextBox)
        Me.Controls.Add(Me.PhoneNumberLabel)
        Me.Controls.Add(Me.DepartementContactLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ShippingButton)
        Me.Controls.Add(Me.OrderProcessingButton)
        Me.Controls.Add(Me.MarketingButton)
        Me.Controls.Add(Me.CustomerRelationsButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VBMailOrderForm"
        Me.Text = "VB Mail Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerRelationsButton As Button
    Friend WithEvents MarketingButton As Button
    Friend WithEvents OrderProcessingButton As Button
    Friend WithEvents ShippingButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DepartementContactLabel As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents DepartmentContactTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
End Class
