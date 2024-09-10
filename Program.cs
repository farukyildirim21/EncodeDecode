using System.Text;

class main{
    public static void Main(string[]args){
        
        // it stores bytes differently especially in turkisk charackter.
        var a = "farukş"; 
       
        var ascii= Encoding.ASCII.GetBytes(a);
        var utf8= Encoding.UTF8.GetBytes(a);
        var utf32= Encoding.UTF32.GetBytes(a);
        var unicode= Encoding.Unicode.GetBytes(a);

        var dascii= Encoding.ASCII.GetString(ascii);
        var dutf8= Encoding.ASCII.GetString(utf8);
        var dutf32= Encoding.ASCII.GetString(utf32);
        var dunicode= Encoding.ASCII.GetString(unicode);

         Console.WriteLine("ascii: "+BitConverter.ToString(ascii));
         Console.WriteLine("utfk8: "+ BitConverter.ToString(utf8));
         Console.WriteLine("utf32: "+BitConverter.ToString(utf32));
         Console.WriteLine("unicode: "+BitConverter.ToString(unicode));

            Console.WriteLine("dascii: "+dascii);
            Console.WriteLine("dutf8: "+dutf8);
            Console.WriteLine("dutf32: "+dutf32);
             Console.WriteLine("dunicode: "+dunicode);
         
         
        

        


    }
}
