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
    [ASN1Sequence(Name = "DefineEventAction_Request", IsSet = false)]
    public class DefineEventAction_Request : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(DefineEventAction_Request));
        private ConfirmedServiceRequest confirmedServiceRequest_;
        private Request_Detail cs_extension_;

        private bool cs_extension_present;
        private ObjectName eventActionName_;


        private ICollection<Modifier> listOfModifier_;

        private bool listOfModifier_present;

        [ASN1Element(Name = "eventActionName", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public ObjectName EventActionName
        {
            get
            {
                return eventActionName_;
            }
            set
            {
                eventActionName_ = value;
            }
        }

        [ASN1SequenceOf(Name = "listOfModifier", IsSetOf = false)]
        [ASN1Element(Name = "listOfModifier", IsOptional = true, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public ICollection<Modifier> ListOfModifier
        {
            get
            {
                return listOfModifier_;
            }
            set
            {
                listOfModifier_ = value;
                listOfModifier_present = true;
            }
        }


        [ASN1Element(Name = "confirmedServiceRequest", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public ConfirmedServiceRequest ConfirmedServiceRequest
        {
            get
            {
                return confirmedServiceRequest_;
            }
            set
            {
                confirmedServiceRequest_ = value;
            }
        }


        [ASN1Element(Name = "cs-extension", IsOptional = true, HasTag = true, Tag = 79, HasDefaultValue = false)]
        public Request_Detail Cs_extension
        {
            get
            {
                return cs_extension_;
            }
            set
            {
                cs_extension_ = value;
                cs_extension_present = true;
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

        public bool isListOfModifierPresent()
        {
            return listOfModifier_present;
        }

        public bool isCs_extensionPresent()
        {
            return cs_extension_present;
        }
    }
}