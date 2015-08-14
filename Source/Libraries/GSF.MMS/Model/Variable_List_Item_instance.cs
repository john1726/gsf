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
    [ASN1Sequence(Name = "Variable_List_Item_instance", IsSet = false)]
    public class Variable_List_Item_instance : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Variable_List_Item_instance));
        private AlternateAccess alternateAccess_;

        private bool alternateAccess_present;
        private Named_Variable_instance namedItem_;

        private bool namedItem_present;
        private Unnamed_Variable_instance unnamedItem_;

        private bool unnamedItem_present;

        [ASN1Element(Name = "unnamedItem", IsOptional = true, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public Unnamed_Variable_instance UnnamedItem
        {
            get
            {
                return unnamedItem_;
            }
            set
            {
                unnamedItem_ = value;
                unnamedItem_present = true;
            }
        }


        [ASN1Element(Name = "namedItem", IsOptional = true, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public Named_Variable_instance NamedItem
        {
            get
            {
                return namedItem_;
            }
            set
            {
                namedItem_ = value;
                namedItem_present = true;
            }
        }


        [ASN1Element(Name = "alternateAccess", IsOptional = true, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public AlternateAccess AlternateAccess
        {
            get
            {
                return alternateAccess_;
            }
            set
            {
                alternateAccess_ = value;
                alternateAccess_present = true;
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


        public bool isUnnamedItemPresent()
        {
            return unnamedItem_present;
        }

        public bool isNamedItemPresent()
        {
            return namedItem_present;
        }

        public bool isAlternateAccessPresent()
        {
            return alternateAccess_present;
        }
    }
}