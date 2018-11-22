Module ParameterByVal
    'Prosedur Tukar memiliki dua parameter (x, y) dengan modifier ByVal
    'Dilakukan pertukaran nilai parameter x dan y
    Sub Tukar(ByVal x As Integer, ByVal y As Integer)
        Dim temp As Integer
        temp = x
        x = y
        y = temp

        Console.WriteLine("Saat ditukar, nilai x = {0} dan nilai y = {1}" & vbNewLine, x, y)
    End Sub

    Sub Main()
        Dim a As Integer = 8
        Dim b As Integer = 6

        Console.WriteLine("Sebelum ditukar, nilai a = {0} dan nilai b = {1}" & vbNewLine, a, b)

        'Memanggil prosedur Tukar untuk menukar nilai variabel a dan b
        'Argumen berupa variabel a berisi nilai 8 dilewatkan melalui parameter x
        'Argumen berupa variabel b berisi nilai 6 dilewatkan melalui parameter y
        Tukar(a, b)

        Console.WriteLine("Setelah ditukar, nilai a = {0} dan nilai b = {1}" & vbNewLine, a, b)

        Console.ReadLine()
    End Sub
End Module