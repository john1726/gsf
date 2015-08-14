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
    [ASN1Sequence(Name = "GetUnitControlAttributes_Response", IsSet = false)]
    public class GetUnitControlAttributes_Response : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(GetUnitControlAttributes_Response));
        private ICollection<Identifier> domains_;


        private ICollection<Identifier> programInvocations_;

        [ASN1SequenceOf(Name = "domains", IsSetOf = false)]
        [ASN1Element(Name = "domains", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public ICollection<Identifier> Domains
        {
            get
            {
                return domains_;
            }
            set
            {
                domains_ = value;
            }
        }

        [ASN1SequenceOf(Name = "programInvocations", IsSetOf = false)]
        [ASN1Element(Name = "programInvocations", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public ICollection<Identifier> ProgramInvocations
        {
            get
            {
                return programInvocations_;
            }
            set
            {
                programInvocations_ = value;
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