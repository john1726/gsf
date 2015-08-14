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
    [ASN1Sequence(Name = "FileDirectory_Request", IsSet = false)]
    public class FileDirectory_Request : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(FileDirectory_Request));
        private FileName continueAfter_;

        private bool continueAfter_present;
        private FileName fileSpecification_;

        private bool fileSpecification_present;

        [ASN1Element(Name = "fileSpecification", IsOptional = true, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public FileName FileSpecification
        {
            get
            {
                return fileSpecification_;
            }
            set
            {
                fileSpecification_ = value;
                fileSpecification_present = true;
            }
        }


        [ASN1Element(Name = "continueAfter", IsOptional = true, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public FileName ContinueAfter
        {
            get
            {
                return continueAfter_;
            }
            set
            {
                continueAfter_ = value;
                continueAfter_present = true;
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

        public bool isFileSpecificationPresent()
        {
            return fileSpecification_present;
        }

        public bool isContinueAfterPresent()
        {
            return continueAfter_present;
        }
    }
}