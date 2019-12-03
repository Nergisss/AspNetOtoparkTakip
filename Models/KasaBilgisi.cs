using System;
using OtoparkTakip.Models;

namespace OtoparkTakip.Models
{
    public class KasaBilgisi
    {
       public  int  kasaID{get;set;}
       public int vardiyaID{get;set;}
       public virtual VardiyaBilgisi VardiyaBilgisi{get;set;}
       public int aylikBorc{get;set;}
       public int ekUcret{get;set;}

       public int toplamBorc{get;set;}
       public int odenenBorc{get;set;}
       public int kalanBorc{get;set;}

    }
}