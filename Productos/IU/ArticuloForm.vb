Public Class ArticuloForm
    Dim operacion_ As String
    Dim MiArticulo As New ArticuloClass
    Dim RubroCombo_ As Integer
    Dim indice_ As Integer

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property


    Public Property indice() As Integer
        Get
            Return indice_
        End Get
        Set(ByVal value As Integer)

            indice_ = value
        End Set
    End Property
    Public Property RubroCombo() As Integer
        Get
            Return RubroCombo_
        End Get
        Set(ByVal value As Integer)
            RubroCombo_ = value
        End Set
    End Property

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click

        If operacion_ <> "Agregar" Then
            MiArticulo.Id = CInt(IdText.Text)
        End If

        MiArticulo.Descripcion = DescripcionText.Text
        MiArticulo.IdRubro = RubroCombox.SelectedIndex

        Select Case operacion_

            Case "Agregar"
                ArticuloList.InsertarArticulo(MiArticulo)

            Case "Modificar"
                ArticuloList.ActualizarArticulo(MiArticulo)
                ArticulosGrid.DataGridView1.Refresh()

            Case "Eliminar"
                ArticuloList.EliminarArticulo(MiArticulo)

        End Select


        Me.Close()
    End Sub
    Private Sub ArticulosForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'De donde traigo los datos
        RubroCombox.DataSource = RubroList.TraerRubros
        'Los valores que quiero mostrar
        RubroCombox.DisplayMember = "Descripcion"
        RubroCombox.ValueMember = "Id"

        RubroCombox.SelectedValue = RubroCombox

        MiArticulo.IdRubro = CInt(RubroCombox.SelectedValue)
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

End Class
