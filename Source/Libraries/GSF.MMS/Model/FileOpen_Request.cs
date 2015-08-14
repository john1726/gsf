//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System.Runtime.CompilerServices;
using GSF.ASN1;
using GSF.ASN1.Attributes;
using GSF.ASN1.Coders;

namespace GSF.MMS.Model
{
    
    [ASN1PreparedElement]
    [ASN1Sequence(Name = "FileOpen_Request", IsSet = false)]
    public class FileOpen_Request : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(FileOpen_Request));
        private FileName fileName_;


        private Unsigned32 initialPosition_;

        [ASN1Element(Name = "fileName", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public FileName FileName
        {
            get
            {
                return fileName_;
            }
            set
            {
                fileName_ = value;
            }
        }

        [ASN1Element(Name = "initialPosition", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public Unsigned32 InitialPosition
        {
            get
            {
                return initialPosition_;
            }
            set
            {
                initialPosition_ = value;
            }
        }


        public void initWithDefaults()
        {
        }


        public IASN1PreparedElementData PreparedData
        {
            get
            {
                return preparedData;
            }
        }
    }
}