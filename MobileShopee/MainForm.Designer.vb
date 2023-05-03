<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        lstItems = New ListBox()
        cmbQuantity = New ComboBox()
        dgvCart = New DataGridView()
        btnAddToCart = New Button()
        btnCalculateTotal = New Button()
        lblTotal = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        btnLogout = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label13 = New Label()
        Splitter1 = New Splitter()
        Splitter2 = New Splitter()
        Label12 = New Label()
        Label11 = New Label()
        Label14 = New Label()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        Label15 = New Label()
        PictureBox12 = New PictureBox()
        Label16 = New Label()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lstItems
        ' 
        lstItems.FormattingEnabled = True
        lstItems.ItemHeight = 15
        lstItems.Location = New Point(584, 43)
        lstItems.Name = "lstItems"
        lstItems.Size = New Size(317, 94)
        lstItems.TabIndex = 0
        ' 
        ' cmbQuantity
        ' 
        cmbQuantity.FormattingEnabled = True
        cmbQuantity.Location = New Point(584, 143)
        cmbQuantity.Name = "cmbQuantity"
        cmbQuantity.Size = New Size(82, 23)
        cmbQuantity.TabIndex = 1
        ' 
        ' dgvCart
        ' 
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.Location = New Point(584, 179)
        dgvCart.Name = "dgvCart"
        dgvCart.Size = New Size(317, 235)
        dgvCart.TabIndex = 2
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.BackColor = Color.SpringGreen
        btnAddToCart.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddToCart.ForeColor = Color.Indigo
        btnAddToCart.Location = New Point(805, 143)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(96, 29)
        btnAddToCart.TabIndex = 3
        btnAddToCart.Text = "Add to Cart"
        btnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' btnCalculateTotal
        ' 
        btnCalculateTotal.BackColor = Color.SpringGreen
        btnCalculateTotal.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCalculateTotal.ForeColor = Color.Indigo
        btnCalculateTotal.Location = New Point(665, 425)
        btnCalculateTotal.Name = "btnCalculateTotal"
        btnCalculateTotal.Size = New Size(142, 28)
        btnCalculateTotal.TabIndex = 4
        btnCalculateTotal.Text = "Calculate the Total"
        btnCalculateTotal.UseVisualStyleBackColor = False
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotal.Location = New Point(671, 480)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(14, 17)
        lblTotal.TabIndex = 5
        lblTotal.Text = "_"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(31, 172)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 7
        Label1.Text = "Samsung Galaxy 10"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(162, 41)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 128)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(295, 38)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 128)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(422, 39)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 128)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(162, 214)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 128)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(295, 214)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(100, 128)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 12
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(31, 385)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(100, 128)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 13
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(162, 385)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(100, 128)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 14
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(295, 385)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(100, 128)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 15
        PictureBox9.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.SpringGreen
        btnLogout.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogout.ForeColor = Color.Indigo
        btnLogout.Location = New Point(846, 508)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(69, 31)
        btnLogout.TabIndex = 16
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Indigo
        Label2.Location = New Point(582, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(225, 17)
        Label2.TabIndex = 17
        Label2.Text = "Select the item you want to buy."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(173, 172)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 15)
        Label3.TabIndex = 18
        Label3.Text = "Redmi Note 6"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(295, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 19
        Label4.Text = "Redmi Note 5"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(43, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 20
        Label5.Text = "Apple iPhone 5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(171, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 21
        Label6.Text = "Redmi Note 8"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(295, 345)
        Label7.Name = "Label7"
        Label7.Size = New Size(112, 15)
        Label7.TabIndex = 22
        Label7.Text = "Samsung Galaxy 56"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(30, 519)
        Label8.Name = "Label8"
        Label8.Size = New Size(111, 15)
        Label8.TabIndex = 23
        Label8.Text = "Samsung Galaxy 57"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(171, 519)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 15)
        Label9.TabIndex = 24
        Label9.Text = "Redmi Note 9"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(296, 519)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 15)
        Label10.TabIndex = 25
        Label10.Text = "Redmi Note 7"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.ForeColor = Color.Indigo
        Label13.Location = New Point(31, 9)
        Label13.Name = "Label13"
        Label13.Size = New Size(123, 20)
        Label13.TabIndex = 29
        Label13.Text = "Mobile Shopee"
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 543)
        Splitter1.TabIndex = 30
        Splitter1.TabStop = False
        ' 
        ' Splitter2
        ' 
        Splitter2.Location = New Point(3, 0)
        Splitter2.Name = "Splitter2"
        Splitter2.Size = New Size(3, 543)
        Splitter2.TabIndex = 31
        Splitter2.TabStop = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.ForeColor = Color.Indigo
        Label12.Location = New Point(-3, 360)
        Label12.Name = "Label12"
        Label12.Size = New Size(543, 17)
        Label12.TabIndex = 28
        Label12.Text = "___________________________________________________________________________________________________________"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.Indigo
        Label11.Location = New Point(-3, 187)
        Label11.Name = "Label11"
        Label11.Size = New Size(543, 17)
        Label11.TabIndex = 27
        Label11.Text = "___________________________________________________________________________________________________________"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(431, 172)
        Label14.Name = "Label14"
        Label14.Size = New Size(80, 15)
        Label14.TabIndex = 32
        Label14.Text = "Redmi Note 4"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(31, 214)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(110, 124)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 33
        PictureBox10.TabStop = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(422, 214)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(112, 128)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 34
        PictureBox11.TabStop = False
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(434, 345)
        Label15.Name = "Label15"
        Label15.Size = New Size(88, 15)
        Label15.TabIndex = 35
        Label15.Text = "Apple iPhone 6"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(422, 385)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(112, 128)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 36
        PictureBox12.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(434, 519)
        Label16.Name = "Label16"
        Label16.Size = New Size(87, 15)
        Label16.TabIndex = 37
        Label16.Text = "Apple iPhone 7"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSpringGreen
        ClientSize = New Size(922, 543)
        Controls.Add(Label16)
        Controls.Add(PictureBox12)
        Controls.Add(Label15)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox10)
        Controls.Add(Label14)
        Controls.Add(Splitter2)
        Controls.Add(Splitter1)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnLogout)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(lblTotal)
        Controls.Add(btnCalculateTotal)
        Controls.Add(btnAddToCart)
        Controls.Add(dgvCart)
        Controls.Add(cmbQuantity)
        Controls.Add(lstItems)
        Name = "MainForm"
        Text = "MainForm"
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstItems As ListBox
    Friend WithEvents cmbQuantity As ComboBox
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnCalculateTotal As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Label16 As Label
End Class
