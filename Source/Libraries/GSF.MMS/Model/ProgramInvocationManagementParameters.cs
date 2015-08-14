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
using GSF.ASN1.Types;

namespace GSF.MMS.Model
{
    
    [ASN1PreparedElement]
    [ASN1Sequence(Name = "ProgramInvocationManagementParameters", IsSet = false)]
    public class ProgramInvocationManagementParameters : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(ProgramInvocationManagementParameters));
        private long executionArgMaxSize_;


        private MMSString executionArgParseRules_;


        private ICollection<ObjectIdentifier> executionArgSyntaxes_;


        private MMSString programLoction_;


        private bool stepMode_;

        [ASN1Integer(Name = "")]
        [ASN1Element(Name = "executionArgMaxSize", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public long ExecutionArgMaxSize
        {
            get
            {
                return executionArgMaxSize_;
            }
            set
            {
                executionArgMaxSize_ = value;
            }
        }

        [ASN1Element(Name = "executionArgParseRules", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public MMSString ExecutionArgParseRules
        {
            get
            {
                return executionArgParseRules_;
            }
            set
            {
                executionArgParseRules_ = value;
            }
        }

        [ASN1ObjectIdentifier(Name = "")]
        [ASN1SequenceOf(Name = "executionArgSyntaxes", IsSetOf = false)]
        [ASN1Element(Name = "executionArgSyntaxes", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public ICollection<ObjectIdentifier> ExecutionArgSyntaxes
        {
            get
            {
                return executionArgSyntaxes_;
            }
            set
            {
                executionArgSyntaxes_ = value;
            }
        }

        [ASN1Element(Name = "programLoction", IsOptional = false, HasTag = true, Tag = 3, HasDefaultValue = false)]
        public MMSString ProgramLoction
        {
            get
            {
                return programLoction_;
            }
            set
            {
                programLoction_ = value;
            }
        }

        [ASN1Boolean(Name = "")]
        [ASN1Element(Name = "stepMode", IsOptional = false, HasTag = true, Tag = 4, HasDefaultValue = false)]
        public bool StepMode
        {
            get
            {
                return stepMode_;
            }
            set
            {
                stepMode_ = value;
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