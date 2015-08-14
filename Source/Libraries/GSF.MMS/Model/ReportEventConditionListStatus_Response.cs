//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System.Runtime.CompilerServices;
using System.Collections.Generic;
using GSF.ASN1;
using GSF.ASN1.Attributes;
using GSF.ASN1.Coders;

namespace GSF.MMS.Model
{
    
    [ASN1PreparedElement]
    [ASN1Sequence(Name = "ReportEventConditionListStatus_Response", IsSet = false)]
    public class ReportEventConditionListStatus_Response : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ReportEventConditionListStatus_Response));
        private ICollection<EventConditionStatus> listOfEventConditionStatus_;


        private bool moreFollows_;

        [ASN1SequenceOf(Name = "listOfEventConditionStatus", IsSetOf = false)]
        [ASN1Element(Name = "listOfEventConditionStatus", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public ICollection<EventConditionStatus> ListOfEventConditionStatus
        {
            get
            {
                return listOfEventConditionStatus_;
            }
            set
            {
                listOfEventConditionStatus_ = value;
            }
        }

        [ASN1Boolean(Name = "")]
        [ASN1Element(Name = "moreFollows", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = true)]
        public bool MoreFollows
        {
            get
            {
                return moreFollows_;
            }
            set
            {
                moreFollows_ = value;
            }
        }


        public void initWithDefaults()
        {
            bool param_MoreFollows =
                false;
            MoreFollows = param_MoreFollows;
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