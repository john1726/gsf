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
    [ASN1Sequence(Name = "ReportJournalStatus_Response", IsSet = false)]
    public class ReportJournalStatus_Response : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ReportJournalStatus_Response));
        private Identifier accessControlList_;

        private bool accessControlList_present;
        private Unsigned32 currentEntries_;


        private bool mmsDeletable_;

        [ASN1Element(Name = "currentEntries", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public Unsigned32 CurrentEntries
        {
            get
            {
                return currentEntries_;
            }
            set
            {
                currentEntries_ = value;
            }
        }

        [ASN1Boolean(Name = "")]
        [ASN1Element(Name = "mmsDeletable", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public bool MmsDeletable
        {
            get
            {
                return mmsDeletable_;
            }
            set
            {
                mmsDeletable_ = value;
            }
        }


        [ASN1Element(Name = "accessControlList", IsOptional = true, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public Identifier AccessControlList
        {
            get
            {
                return accessControlList_;
            }
            set
            {
                accessControlList_ = value;
                accessControlList_present = true;
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

        public bool isAccessControlListPresent()
        {
            return accessControlList_present;
        }
    }
}