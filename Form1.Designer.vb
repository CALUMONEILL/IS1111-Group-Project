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
        Me.components = New System.ComponentModel.Container()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_IS1111_GRP_PROJDataSet = New IS1111_Group_Project.db_IS1111_GRP_PROJDataSet()
        Me.TblStaffTableAdapter = New IS1111_Group_Project.db_IS1111_GRP_PROJDataSetTableAdapters.tblStaffTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_IS1111_GRP_PROJDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblStaff"
        Me.BindingSource1.DataSource = Me.Db_IS1111_GRP_PROJDataSet
        '
        'Db_IS1111_GRP_PROJDataSet
        '
        Me.Db_IS1111_GRP_PROJDataSet.DataSetName = "db_IS1111_GRP_PROJDataSet"
        Me.Db_IS1111_GRP_PROJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStaffTableAdapter
        '
        Me.TblStaffTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_IS1111_GRP_PROJDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Db_IS1111_GRP_PROJDataSet As db_IS1111_GRP_PROJDataSet
    Friend WithEvents TblStaffTableAdapter As db_IS1111_GRP_PROJDataSetTableAdapters.tblStaffTableAdapter
End Class
