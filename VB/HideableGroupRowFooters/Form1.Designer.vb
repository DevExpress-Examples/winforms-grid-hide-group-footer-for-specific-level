Namespace HideableGroupRowFooters

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.myGridControl1 = New HideableGroupRowFooters.MyGridControl()
            Me.myGridView1 = New HideableGroupRowFooters.MyGridView()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
            CType((Me.myGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.myGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' myGridControl1
            ' 
            Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.myGridControl1.Location = New System.Drawing.Point(0, 69)
            Me.myGridControl1.MainView = Me.myGridView1
            Me.myGridControl1.Name = "myGridControl1"
            Me.myGridControl1.Size = New System.Drawing.Size(804, 445)
            Me.myGridControl1.TabIndex = 0
            Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.myGridView1})
            ' 
            ' myGridView1
            ' 
            Me.myGridView1.GridControl = Me.myGridControl1
            Me.myGridView1.Name = "myGridView1"
            AddHandler Me.myGridView1.ShowGroupFooter, New HideableGroupRowFooters.ShowGroupFooterEventHandler(AddressOf Me.gridViewOverride1_ShowGroupFooter)
            AddHandler Me.myGridView1.EndGrouping, New System.EventHandler(AddressOf Me.gridViewOverride1_EndGrouping)
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkEdit1)
            Me.panel1.Controls.Add(Me.spinEdit1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(804, 69)
            Me.panel1.TabIndex = 5
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 37)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Footer level to hide:"
            ' 
            ' checkEdit1
            ' 
            Me.checkEdit1.Location = New System.Drawing.Point(12, 12)
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = "Hide footer"
            Me.checkEdit1.Size = New System.Drawing.Size(86, 19)
            Me.checkEdit1.TabIndex = 5
            AddHandler Me.checkEdit1.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' spinEdit1
            ' 
            Me.spinEdit1.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(118, 34)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEdit1.Properties.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
            Me.spinEdit1.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEdit1.Size = New System.Drawing.Size(52, 20)
            Me.spinEdit1.TabIndex = 4
            AddHandler Me.spinEdit1.EditValueChanged, New System.EventHandler(AddressOf Me.spinEdit1_EditValueChanged)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(804, 514)
            Me.Controls.Add(Me.myGridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.myGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.myGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType((Me.checkEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private myGridControl1 As HideableGroupRowFooters.MyGridControl

        Private myGridView1 As HideableGroupRowFooters.MyGridView

        Private panel1 As System.Windows.Forms.Panel

        Private label1 As System.Windows.Forms.Label

        Private checkEdit1 As DevExpress.XtraEditors.CheckEdit

        Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
    End Class
End Namespace
