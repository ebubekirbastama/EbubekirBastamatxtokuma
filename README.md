# EbubekirBastamatxtokuma
 Ebubekir Bastama Txt Okuma Programı..
# .dll ne işe yarar
    Bu dll kullanıcıların dosyalardan string verileri rahatlıkla okuması için geliştirilmiştir ve kullancıların hiç uğraşma'dan verileri rahatlıkla okumasını sağlar..
# .dll Nasıl Yükleriz.
    Bu dll'i Nuget Manager'dan "ebubekir bastama txt okuma" yazarak bulabilir ve yükleyebilirsiniz.
    Diğer yüklemeler
    
# Package Manager
      Install-Package Ebubekir.Bastama -Version 1.0.0
      
#.NET CLI

    dotnet add package Ebubekir.Bastama --version 1.0.0
    
#PackageReference

     <PackageReference Include="Ebubekir.Bastama" Version="1.0.0" />
     
#Paket CLI

        paket add Ebubekir.Bastama --version 1.0.0
        
#Bu Sistemi Nasıl Kullanabiliriz.
         .dll'in kullanımı çok basittir ve 2 metod bulunmaktadır.
        
        1-) listbox dolduran Metod
        2-) Dizi Döndüren Metod.
        
 # listbox Döndüren Metod
     
   using EbubekirBastamatxtokuma;
     
     BekraTxtOkuma k = new BekraTxtOkuma();
        k.Txt_Aktar(op.FileName.ToString(),listBox2,false);
 # Dizi Döndüren Metod
   
   using EbubekirBastamatxtokuma;
     
            BekraTxtOkuma k = new BekraTxtOkuma();
           string[] dizi = k.Txt_Aktar_Dizi(op.FileName.ToString(), false);
            for (int i = 0; i < k.Txt_Aktar_Dizi(op.FileName.ToString(),false).Length; i++)
            {
                listBox2.Items.Add(dizi[i].ToString());
            }
