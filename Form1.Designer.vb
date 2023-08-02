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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SelFile = New System.Windows.Forms.Button()
        Me.Archivo = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UpdateFile = New System.Windows.Forms.Button()
        Me.Vista = New System.Windows.Forms.DataGridView()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Latitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Longitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kilometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubKilometro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SelFile
        '
        Me.SelFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SelFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SelFile.Location = New System.Drawing.Point(12, 61)
        Me.SelFile.Name = "SelFile"
        Me.SelFile.Size = New System.Drawing.Size(103, 23)
        Me.SelFile.TabIndex = 0
        Me.SelFile.Text = "Select File"
        Me.SelFile.UseVisualStyleBackColor = True
        '
        'Archivo
        '
        Me.Archivo.Location = New System.Drawing.Point(121, 61)
        Me.Archivo.Name = "Archivo"
        Me.Archivo.ReadOnly = True
        Me.Archivo.Size = New System.Drawing.Size(230, 23)
        Me.Archivo.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "LWD | *.lwd"
        '
        'UpdateFile
        '
        Me.UpdateFile.Enabled = False
        Me.UpdateFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.UpdateFile.Location = New System.Drawing.Point(357, 61)
        Me.UpdateFile.Name = "UpdateFile"
        Me.UpdateFile.Size = New System.Drawing.Size(103, 23)
        Me.UpdateFile.TabIndex = 4
        Me.UpdateFile.Text = "Update File"
        Me.UpdateFile.UseVisualStyleBackColor = True
        '
        'Vista
        '
        Me.Vista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Vista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.SubKilometro})
        Me.Vista.Location = New System.Drawing.Point(12, 91)
        Me.Vista.Name = "Vista"
        Me.Vista.RowHeadersWidth = 4
        Me.Vista.RowTemplate.Height = 25
        Me.Vista.Size = New System.Drawing.Size(448, 263)
        Me.Vista.TabIndex = 9
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Item.Width = 60
        '
        'Latitud
        '
        Me.Latitud.HeaderText = "latitud"
        Me.Latitud.Name = "Latitud"
        Me.Latitud.ReadOnly = True
        Me.Latitud.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Longitud
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Longitud.DefaultCellStyle = DataGridViewCellStyle1
        Me.Longitud.HeaderText = "Longitud"
        Me.Longitud.Name = "Longitud"
        Me.Longitud.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Kilometro
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Kilometro.DefaultCellStyle = DataGridViewCellStyle2
        Me.Kilometro.HeaderText = "KM"
        Me.Kilometro.Name = "Kilometro"
        Me.Kilometro.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Kilometro.Width = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(64, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "          Software   Control   LWD   -   2021          "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(132, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nombre y ubicacion de Archivo LWD"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Longitud"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Latitud"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "KM"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 78
        '
        'SubKilometro
        '
        Me.SubKilometro.HeaderText = "Sub KM"
        Me.SubKilometro.Name = "SubKilometro"
        Me.SubKilometro.Width = 78
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(473, 366)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Vista)
        Me.Controls.Add(Me.UpdateFile)
        Me.Controls.Add(Me.Archivo)
        Me.Controls.Add(Me.SelFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOB INNOVA - Software LWD Version 1.0"
        CType(Me.Vista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SelFile As Button
    Friend WithEvents Archivo As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents UpdateFile As Button
    Friend WithEvents Vista As DataGridView
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Latitud As DataGridViewTextBoxColumn
    Friend WithEvents Longitud As DataGridViewTextBoxColumn
    Friend WithEvents Kilometro As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents SubKilometro As DataGridViewTextBoxColumn
End Class
