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
    [ASN1BoxedType(Name = "Write_Response")]
    public class Write_Response : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Write_Response));
        private ICollection<Write_ResponseChoiceType> val;


        [ASN1SequenceOf(Name = "Write-Response", IsSetOf = false)]
        public ICollection<Write_ResponseChoiceType> Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
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

        public void initValue()
        {
            Value = new List<Write_ResponseChoiceType>();
        }

        public void Add(Write_ResponseChoiceType item)
        {
            Value.Add(item);
        }

        [ASN1PreparedElement]
        [ASN1Choice(Name = "Write-Response")]
        public class Write_ResponseChoiceType : IASN1PreparedElement
        {
            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(Write_ResponseChoiceType));
            private DataAccessError failure_;
            private bool failure_selected;


            private NullObject success_;
            private bool success_selected;

            [ASN1Element(Name = "failure", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
            public DataAccessError Failure
            {
                get
                {
                    return failure_;
                }
                set
                {
                    selectFailure(value);
                }
            }


            [ASN1Null(Name = "success")]
            [ASN1Element(Name = "success", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
            public NullObject Success
            {
                get
                {
                    return success_;
                }
                set
                {
                    selectSuccess(value);
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


            public bool isFailureSelected()
            {
                return failure_selected;
            }


            public void selectFailure(DataAccessError val)
            {
                failure_ = val;
                failure_selected = true;


                success_selected = false;
            }


            public bool isSuccessSelected()
            {
                return success_selected;
            }


            /*public void selectSuccess()
            {
                selectSuccess(new NullObject());
            }*/


            public void selectSuccess(NullObject val)
            {
                success_ = val;
                success_selected = true;


                failure_selected = false;
            }
        }
    }
}