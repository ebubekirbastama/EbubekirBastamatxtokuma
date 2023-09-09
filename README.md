# EbubekirBastamatxtokuma
 Ebubekir Bastama Txt Okuma Programı..
# .dll ne işe yarar
    Bu dll kullanıcıların dosyalardan string verileri rahatlıkla okuması için geliştirilmiştir ve kullancıların hiç uğraşma'dan verileri rahatlıkla okumasını sağlar..
# .dll Nasıl Yükleriz.
    Bu dll'i Nuget Manager'dan "ebubekir bastama txt okuma" yazarak bulabilir ve yükleyebilirsiniz.
    Diğer yüklemeler
    
# Package Manager
      Install-Package Ebubekir.Bastama -Version 2.0.0
      
#.NET CLI

    dotnet add package Ebubekir.Bastama --version 2.0.0
    
#PackageReference

     <PackageReference Include="Ebubekir.Bastama" Version="2.0.0" />
     
#Paket CLI

        paket add Ebubekir.Bastama --version 2.0.0
        
#Bu Sistemi Nasıl Kullanabiliriz.
         .dll'in kullanımı çok basittir ve 3 metod bulunmaktadır.
        
        1-) listbox dolduran Metod.
        2-) Dizi Döndüren Metod.
        3-) Yüksek Boyutlu .txt dosyaları okuma.
        
 # ListBox'a Veri Ekleyen Metod
 
   ```csharp
     
   EBSTxt_Okuma.EBSTxtOkuma.Txtİmport(op.FileName.ToString(), listBox2, false);
   
   ``` 

 # Dizi Döndüren Metod
   
```csharp

 string[] dizi = EBSTxt_Okuma.EBSTxtOkuma.TxtimportDizi(op.FileName.ToString(), false);
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox2.Items.Add(dizi[i]);
            }
```
 # Yüksek Boyutlu txt Dosyası Okuma

   ```csharp
      
    EBSTxt_Okuma.EBSTxtOkuma.ImportLargeFileToListBox(op.FileName.ToString(),ListBox1, false);
    
   ``` 

