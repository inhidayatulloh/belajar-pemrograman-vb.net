Module ModuleMendefinisikanKelasBerisiAtribut
    'Contoh mendefinisikan kelas PersegiEmpat yang memiliki dua atribut/properti.
    Class PersegiEmpat
        'Atribut berupa variabel panjang dan lebar bertipe data Integer.
        Public panjang As Integer
        Public lebar As Integer
    End Class

    Sub Main()
        'Deklarasi dan inisialisasi objek persegiEmpatA dan persegiEmpatB dari kelas PersegiEmpat.
        'Objek akan memiliki atribut dan metode/operasi (jika ada) dari kelas PersegiEmpat.
        Dim persegiEmpatA As PersegiEmpat = New PersegiEmpat()
        Dim persegiEmpatB As PersegiEmpat = New PersegiEmpat()

        'Deklarasi variabel luasPersegiEmpat bertipe data Integer.
        Dim luasPersegiEmpat As Integer

        'Mengisi nilai pada variabel panjang dan lebar dari objek persegiEmpatA dan persegiEmpatB.
        persegiEmpatA.panjang = 5
        persegiEmpatA.lebar = 3

        persegiEmpatB.panjang = 4
        persegiEmpatB.lebar = 4

        'Menghitung luas dari objek persegiEmpatA dan persegiEmpatB.
        'Menyimpan hasil perhitungan pada variabel luarPersegiEmpat.
        'Menampilkan nilai variabel luasPersegiEmpat (berisi luas setiap objek) pada console.
        luasPersegiEmpat = persegiEmpatA.panjang * persegiEmpatA.lebar
        Console.WriteLine("Luas persegiEmpatA = " & luasPersegiEmpat)

        luasPersegiEmpat = persegiEmpatB.panjang * persegiEmpatB.lebar
        Console.WriteLine("Luas persegiEmpatB = " & luasPersegiEmpat)

        'Agar setelah console terbuka/tampil kemudian tidak langsung menutup.
        Console.ReadLine()
    End Sub

End Module
