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
    [ASN1Sequence(Name = "GetAlarmSummary_Response", IsSet = false)]
    public class GetAlarmSummary_Response : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(GetAlarmSummary_Response));
        private ICollection<AlarmSummary> listOfAlarmSummary_;


        private bool moreFollows_;

        [ASN1SequenceOf(Name = "listOfAlarmSummary", IsSetOf = false)]
        [ASN1Element(Name = "listOfAlarmSummary", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public ICollection<AlarmSummary> ListOfAlarmSummary
        {
            get
            {
                return listOfAlarmSummary_;
            }
            set
            {
                listOfAlarmSummary_ = value;
            }
        }

        [ASN1Boolean(Name = "")]
        [ASN1Element(Name = "moreFollows", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = true)]
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