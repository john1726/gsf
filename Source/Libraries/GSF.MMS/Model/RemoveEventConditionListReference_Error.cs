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
    [ASN1Choice(Name = "RemoveEventConditionListReference_Error")]
    public class RemoveEventConditionListReference_Error : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(RemoveEventConditionListReference_Error));
        private ObjectName eventConditionList_;
        private bool eventConditionList_selected;
        private ObjectName eventCondition_;
        private bool eventCondition_selected;


        [ASN1Element(Name = "eventCondition", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public ObjectName EventCondition
        {
            get
            {
                return eventCondition_;
            }
            set
            {
                selectEventCondition(value);
            }
        }


        [ASN1Element(Name = "eventConditionList", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public ObjectName EventConditionList
        {
            get
            {
                return eventConditionList_;
            }
            set
            {
                selectEventConditionList(value);
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


        public bool isEventConditionSelected()
        {
            return eventCondition_selected;
        }


        public void selectEventCondition(ObjectName val)
        {
            eventCondition_ = val;
            eventCondition_selected = true;


            eventConditionList_selected = false;
        }


        public bool isEventConditionListSelected()
        {
            return eventConditionList_selected;
        }


        public void selectEventConditionList(ObjectName val)
        {
            eventConditionList_ = val;
            eventConditionList_selected = true;


            eventCondition_selected = false;
        }
    }
}