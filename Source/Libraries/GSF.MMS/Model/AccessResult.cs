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
    [ASN1Choice(Name = "AccessResult")]
    public class AccessResult : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(AccessResult));
        private DataAccessError failure_;
        private bool failure_selected;


        private Data success_;
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


        [ASN1Element(Name = "success", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public Data Success
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


        public void selectSuccess(Data val)
        {
            success_ = val;
            success_selected = true;


            failure_selected = false;
        }
    }
}