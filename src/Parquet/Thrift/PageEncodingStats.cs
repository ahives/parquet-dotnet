/*
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
namespace Parquet.Thrift
{
   using System.Text;
   using global::Thrift.Protocol;


   /// <summary>
   /// statistics of a given page type and encoding
   /// </summary>
   class PageEncodingStats :
      TBase
   {
      /// <summary>
      /// the page type (data/dic/...) *
      /// 
      /// <seealso cref="PageType"/>
      /// </summary>
      public PageType Page_type { get; set; }

      /// <summary>
      /// encoding of the page *
      /// 
      /// <seealso cref="Encoding"/>
      /// </summary>
      public Encoding Encoding { get; set; }

      /// <summary>
      /// number of pages of this type with this encoding *
      /// </summary>
      public int Count { get; set; }

      public PageEncodingStats()
      {
      }

      public PageEncodingStats(PageType page_type, Encoding encoding, int count) : this()
      {
         this.Page_type = page_type;
         this.Encoding = encoding;
         this.Count = count;
      }

      public void Read(TProtocol iprot)
      {
         iprot.IncrementRecursionDepth();
         try
         {
            bool isset_page_type = false;
            bool isset_encoding = false;
            bool isset_count = false;
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
               field = iprot.ReadFieldBegin();
               if (field.Type == TType.Stop)
               {
                  break;
               }

               switch (field.ID)
               {
                  case 1:
                     if (field.Type == TType.I32)
                     {
                        Page_type = (PageType) iprot.ReadI32();
                        isset_page_type = true;
                     }
                     else
                     {
                        TProtocolUtil.Skip(iprot, field.Type);
                     }

                     break;
                  case 2:
                     if (field.Type == TType.I32)
                     {
                        Encoding = (Encoding) iprot.ReadI32();
                        isset_encoding = true;
                     }
                     else
                     {
                        TProtocolUtil.Skip(iprot, field.Type);
                     }

                     break;
                  case 3:
                     if (field.Type == TType.I32)
                     {
                        Count = iprot.ReadI32();
                        isset_count = true;
                     }
                     else
                     {
                        TProtocolUtil.Skip(iprot, field.Type);
                     }

                     break;
                  default:
                     TProtocolUtil.Skip(iprot, field.Type);
                     break;
               }

               iprot.ReadFieldEnd();
            }

            iprot.ReadStructEnd();
            if (!isset_page_type)
               throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_encoding)
               throw new TProtocolException(TProtocolException.INVALID_DATA);
            if (!isset_count)
               throw new TProtocolException(TProtocolException.INVALID_DATA);
         }
         finally
         {
            iprot.DecrementRecursionDepth();
         }
      }

      public void Write(TProtocol oprot)
      {
         oprot.IncrementRecursionDepth();
         try
         {
            TStruct struc = new TStruct("PageEncodingStats");
            oprot.WriteStructBegin(struc);
            TField field = new TField();
            field.Name = "page_type";
            field.Type = TType.I32;
            field.ID = 1;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32((int) Page_type);
            oprot.WriteFieldEnd();
            field.Name = "encoding";
            field.Type = TType.I32;
            field.ID = 2;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32((int) Encoding);
            oprot.WriteFieldEnd();
            field.Name = "count";
            field.Type = TType.I32;
            field.ID = 3;
            oprot.WriteFieldBegin(field);
            oprot.WriteI32(Count);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
         }
         finally
         {
            oprot.DecrementRecursionDepth();
         }
      }

      public override string ToString()
      {
         StringBuilder __sb = new StringBuilder("PageEncodingStats(");
         __sb.Append(", Page_type: ");
         __sb.Append(Page_type);
         __sb.Append(", Encoding: ");
         __sb.Append(Encoding);
         __sb.Append(", Count: ");
         __sb.Append(Count);
         __sb.Append(")");
         return __sb.ToString();
      }
   }
}
