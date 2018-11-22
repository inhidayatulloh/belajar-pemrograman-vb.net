Public Class VariabelDenganModifierShared
    'Deklarasi variabel counter bertipe data Integer dengan modifier Shared
    'Shared artinya sebanyak apapun objek dari kelas dibuat...
    'hanya akan ada satu variabel counter
    Public Shared counter As Integer

    'Prosedur Increment menambahkan nilai variabel counter dengan 1
    Sub Increment()
        counter += 1
    End Sub

    Shared Sub Main()
        'Deklarasi dan Inisialisasi objek vs1 dari kelas VariabelDenganModifierShared
        Dim vs1 As VariabelDenganModifierShared = New VariabelDenganModifierShared()

        'Memanggil prosedur Increment dari objek vs1
        vs1.Increment()
        vs1.Increment()
        vs1.Increment()

        'Menampilkan nilai variabel counter
        'Karena variabel counter dideklarasikan dengan modifier Shared...
        'maka cara memanggilnya harus menggunakan NamaKelas.namaVariabel
        'Variabel counter akan bernilai 3
        Console.WriteLine("Counter = " & VariabelDenganModifierShared.counter & vbNewLine)

        'Deklarasi dan Inisialisasi objek vs2 dari kelas VariabelDenganModifierShared
        Dim vs2 As VariabelDenganModifierShared = New VariabelDenganModifierShared()

        'Memanggil prosedur Increment dari objek vs2
        vs2.Increment()
        vs2.Increment()

        'Menampilkan kembali nilai variabel counter
        'Prosedur Increment dari objek vs2 menggunakan variabel counter...
        'yang sama dengan yang digunakan oleh objek vs1
        'Variabel counter akan bernilai 5
        Console.WriteLine("Counter = " & VariabelDenganModifierShared.counter & vbNewLine)

        Console.ReadLine()
    End Sub
End Class
