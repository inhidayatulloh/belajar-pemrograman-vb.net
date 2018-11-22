Public Class VariabelStatic
    'Deklarasi variabel counter bertipe data Integer dengan modifier Shared
    'Shared artinya static, sebanyak apapun objek dari kelas dibuat...
    'hanya akan ada satu variabel counter
    Public Shared counter As Integer

    'Prosedur Increment menambahkan nilai variabel counter dengan 1
    Sub Increment()
        counter += 1
    End Sub

    Shared Sub Main()
        'Deklarasi dan Inisialisasi objek sv1 dari kelas StaticVariabel
        Dim sv1 As VariabelStatic = New VariabelStatic()

        'Memanggil prosedur Increment dari objek sv1
        sv1.Increment()
        sv1.Increment()
        sv1.Increment()

        'Menampilkan nilai variabel counter
        'Karena variabel counter dideklarasikan dengan modifier Shared...
        'maka cara memanggilnya harus menggunakan NamaKelas.namaVariabel
        'Variabel counter akan bernilai 3
        Console.WriteLine("Counter = " & VariabelStatic.counter & vbNewLine)

        'Deklarasi dan Inisialisasi objek sv1 dari kelas StaticVariabel
        Dim sv2 As VariabelStatic = New VariabelStatic()

        'Memanggil prosedur Increment dari objek sv2
        sv2.Increment()
        sv2.Increment()

        'Menampilkan kembali nilai variabel counter
        'Prosedur Increment dari objek sv2 menggunakan variabel counter...
        'yang sama dengan yang digunakan oleh objek sv1
        'Variabel counter akan bernilai 5
        Console.WriteLine("Counter = " & VariabelStatic.counter & vbNewLine)

        Console.ReadLine()
    End Sub
End Class