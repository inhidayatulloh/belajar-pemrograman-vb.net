Module ModuleMengaksesKelasDiLuarModule
    Sub Main()
        'Deklarasi dan Inisialisasi objek lingkaranKecil dari kelas ClassLingkaranDiLuarModule.
        'ClassLingkaranDiLuarModule merupakan kelas yang ada di luar module pada file .vb tersendiri.
        'ClassLingkaranDiLuarModule.vb masih di dalam satu projek yang sama dengan ModuleMengaksesKelasDiLuarModule.vb
        Dim lingkaranKecil As ClassLingkaranDiLuarModule = New ClassLingkaranDiLuarModule(8.4)

        'Memanggil fungsi GetKeliling dari objek lingkaranKecil untuk mendapatkan nilai keliling lingkaran.
        'Langsung menampilkan nilai keliling lingkaran tanpa menyimpannya terlebih dahulu ke dalam variabel.
        'ToString("0.00") mengkonversi Double ke String dengan format dua angka di belakang koma.
        Console.WriteLine("Keliling lingkaranKecil = " & lingkaranKecil.GetKeliling().ToString("0.00"))

        'Memanggil fungsi GetLuas dari objek lingkaranKecil untuk mendapatkan nilai luas lingkaran.
        'Langsung menampilkan nilai luas lingkaran tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Luas lingkaranKecil = " & lingkaranKecil.GetLuas().ToString("0.00") & vbNewLine)

        Dim lingkaranSedang As ClassLingkaranDiLuarModule = New ClassLingkaranDiLuarModule(27.5)
        Console.WriteLine("Keliling lingkaranSedang = " & lingkaranSedang.GetKeliling().ToString("0.00"))
        Console.WriteLine("Luas lingkaranSedang = " & lingkaranSedang.GetLuas().ToString("0.00") & vbNewLine)

        Dim lingkaranBesar As ClassLingkaranDiLuarModule = New ClassLingkaranDiLuarModule(100.8)
        Console.WriteLine("Keliling lingkaranBesar = " & lingkaranBesar.GetKeliling().ToString("0.00"))
        Console.WriteLine("Luas lingkaranBesar = " & lingkaranBesar.GetLuas().ToString("0.00"))

        Console.ReadLine()

    End Sub
End Module
