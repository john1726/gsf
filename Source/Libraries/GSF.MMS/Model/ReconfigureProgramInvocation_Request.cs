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
    [ASN1Sequence(Name = "ReconfigureProgramInvocation_Request", IsSet = false)]
    public class ReconfigureProgramInvocation_Request : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ReconfigureProgramInvocation_Request));
        private ICollection<Identifier> domainsToAdd_;
        private ICollection<Identifier> domainsToRemove_;
        private Identifier newProgramInvocationName_;

        private bool newProgramInvocationName_present;
        private Identifier oldProgramInvocationName_;

        [ASN1Element(Name = "oldProgramInvocationName", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public Identifier OldProgramInvocationName
        {
            get
            {
                return oldProgramInvocationName_;
            }
            set
            {
                oldProgramInvocationName_ = value;
            }
        }

        [ASN1Element(Name = "newProgramInvocationName", IsOptional = true, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public Identifier NewProgramInvocationName
        {
            get
            {
                return newProgramInvocationName_;
            }
            set
            {
                newProgramInvocationName_ = value;
                newProgramInvocationName_present = true;
            }
        }


        [ASN1SequenceOf(Name = "domainsToAdd", IsSetOf = false)]
        [ASN1Element(Name = "domainsToAdd", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public ICollection<Identifier> DomainsToAdd
        {
            get
            {
                return domainsToAdd_;
            }
            set
            {
                domainsToAdd_ = value;
            }
        }


        [ASN1SequenceOf(Name = "domainsToRemove", IsSetOf = false)]
        [ASN1Element(Name = "domainsToRemove", IsOptional = false, HasTag = true, Tag = 3, HasDefaultValue = false)]
        public ICollection<Identifier> DomainsToRemove
        {
            get
            {
                return domainsToRemove_;
            }
            set
            {
                domainsToRemove_ = value;
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

        public bool isNewProgramInvocationNamePresent()
        {
            return newProgramInvocationName_present;
        }
    }
}