Public Class frmProductList
    Private Sub frmProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PosdbDataSet.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.PosdbDataSet.product)

    End Sub
End Class