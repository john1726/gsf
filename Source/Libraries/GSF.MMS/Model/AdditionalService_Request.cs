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
    [ASN1Choice(Name = "AdditionalService_Request")]
    public class AdditionalService_Request : IASN1PreparedElement
    {
        private static readonly IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(AdditionalService_Request));
        private AddEventConditionListReference_Request addECLReference_;
        private bool addECLReference_selected;
        private AddToUnitControl_Request addToUC_;
        private bool addToUC_selected;
        private AlterEventConditionListMonitoring_Request alterECLMonitoring_;
        private bool alterECLMonitoring_selected;
        private AlterProgramInvocationAttributes_Request alterPI_;
        private bool alterPI_selected;
        private CreateUnitControl_Request createUC_;
        private bool createUC_selected;
        private DefineEventConditionList_Request defineECL_;
        private bool defineECL_selected;
        private DeleteEventConditionList_Request deleteECL_;
        private bool deleteECL_selected;
        private DeleteUnitControl_Request deleteUC_;
        private bool deleteUC_selected;
        private GetEventConditionListAttributes_Request getECLAttributes_;
        private bool getECLAttributes_selected;
        private GetUnitControlAttributes_Request getUCAttributes_;
        private bool getUCAttributes_selected;


        private InitiateUnitControlLoad_Request initiateUCLoad_;
        private bool initiateUCLoad_selected;
        private LoadUnitControlFromFile_Request loadUCFromFile_;
        private bool loadUCFromFile_selected;
        private RemoveEventConditionListReference_Request removeECLReference_;
        private bool removeECLReference_selected;
        private RemoveFromUnitControl_Request removeFromUC_;
        private bool removeFromUC_selected;
        private ReportEventConditionListStatus_Request reportECLStatus_;
        private bool reportECLStatus_selected;
        private Select_Request select_;
        private bool select_selected;
        private StartUnitControl_Request startUC_;
        private bool startUC_selected;
        private StopUnitControl_Request stopUC_;
        private bool stopUC_selected;
        private StoreUnitControlToFile_Request storeUCToFile_;
        private bool storeUCToFile_selected;


        private UnitControlLoadSegment_Request uCLoad_;
        private bool uCLoad_selected;


        private UnitControlUpload_Request uCUpload_;
        private bool uCUpload_selected;
        private VMDReset_Request vMDReset_;
        private bool vMDReset_selected;
        private VMDStop_Request vMDStop_;
        private bool vMDStop_selected;


        [ASN1Element(Name = "vMDStop", IsOptional = false, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public VMDStop_Request VMDStop
        {
            get
            {
                return vMDStop_;
            }
            set
            {
                selectVMDStop(value);
            }
        }

        [ASN1Element(Name = "vMDReset", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public VMDReset_Request VMDReset
        {
            get
            {
                return vMDReset_;
            }
            set
            {
                selectVMDReset(value);
            }
        }

        [ASN1Element(Name = "select", IsOptional = false, HasTag = true, Tag = 2, HasDefaultValue = false)]
        public Select_Request Select
        {
            get
            {
                return select_;
            }
            set
            {
                selectSelect(value);
            }
        }

        [ASN1Element(Name = "alterPI", IsOptional = false, HasTag = true, Tag = 3, HasDefaultValue = false)]
        public AlterProgramInvocationAttributes_Request AlterPI
        {
            get
            {
                return alterPI_;
            }
            set
            {
                selectAlterPI(value);
            }
        }

        [ASN1Element(Name = "initiateUCLoad", IsOptional = false, HasTag = true, Tag = 4, HasDefaultValue = false)]
        public InitiateUnitControlLoad_Request InitiateUCLoad
        {
            get
            {
                return initiateUCLoad_;
            }
            set
            {
                selectInitiateUCLoad(value);
            }
        }

        [ASN1Element(Name = "uCLoad", IsOptional = false, HasTag = true, Tag = 5, HasDefaultValue = false)]
        public UnitControlLoadSegment_Request UCLoad
        {
            get
            {
                return uCLoad_;
            }
            set
            {
                selectUCLoad(value);
            }
        }


        [ASN1Element(Name = "uCUpload", IsOptional = false, HasTag = true, Tag = 6, HasDefaultValue = false)]
        public UnitControlUpload_Request UCUpload
        {
            get
            {
                return uCUpload_;
            }
            set
            {
                selectUCUpload(value);
            }
        }


        [ASN1Element(Name = "startUC", IsOptional = false, HasTag = true, Tag = 7, HasDefaultValue = false)]
        public StartUnitControl_Request StartUC
        {
            get
            {
                return startUC_;
            }
            set
            {
                selectStartUC(value);
            }
        }


        [ASN1Element(Name = "stopUC", IsOptional = false, HasTag = true, Tag = 8, HasDefaultValue = false)]
        public StopUnitControl_Request StopUC
        {
            get
            {
                return stopUC_;
            }
            set
            {
                selectStopUC(value);
            }
        }


        [ASN1Element(Name = "createUC", IsOptional = false, HasTag = true, Tag = 9, HasDefaultValue = false)]
        public CreateUnitControl_Request CreateUC
        {
            get
            {
                return createUC_;
            }
            set
            {
                selectCreateUC(value);
            }
        }


        [ASN1Element(Name = "addToUC", IsOptional = false, HasTag = true, Tag = 10, HasDefaultValue = false)]
        public AddToUnitControl_Request AddToUC
        {
            get
            {
                return addToUC_;
            }
            set
            {
                selectAddToUC(value);
            }
        }


        [ASN1Element(Name = "removeFromUC", IsOptional = false, HasTag = true, Tag = 11, HasDefaultValue = false)]
        public RemoveFromUnitControl_Request RemoveFromUC
        {
            get
            {
                return removeFromUC_;
            }
            set
            {
                selectRemoveFromUC(value);
            }
        }


        [ASN1Element(Name = "getUCAttributes", IsOptional = false, HasTag = true, Tag = 12, HasDefaultValue = false)]
        public GetUnitControlAttributes_Request GetUCAttributes
        {
            get
            {
                return getUCAttributes_;
            }
            set
            {
                selectGetUCAttributes(value);
            }
        }


        [ASN1Element(Name = "loadUCFromFile", IsOptional = false, HasTag = true, Tag = 13, HasDefaultValue = false)]
        public LoadUnitControlFromFile_Request LoadUCFromFile
        {
            get
            {
                return loadUCFromFile_;
            }
            set
            {
                selectLoadUCFromFile(value);
            }
        }


        [ASN1Element(Name = "storeUCToFile", IsOptional = false, HasTag = true, Tag = 14, HasDefaultValue = false)]
        public StoreUnitControlToFile_Request StoreUCToFile
        {
            get
            {
                return storeUCToFile_;
            }
            set
            {
                selectStoreUCToFile(value);
            }
        }


        [ASN1Element(Name = "deleteUC", IsOptional = false, HasTag = true, Tag = 15, HasDefaultValue = false)]
        public DeleteUnitControl_Request DeleteUC
        {
            get
            {
                return deleteUC_;
            }
            set
            {
                selectDeleteUC(value);
            }
        }


        [ASN1Element(Name = "defineECL", IsOptional = false, HasTag = true, Tag = 16, HasDefaultValue = false)]
        public DefineEventConditionList_Request DefineECL
        {
            get
            {
                return defineECL_;
            }
            set
            {
                selectDefineECL(value);
            }
        }


        [ASN1Element(Name = "deleteECL", IsOptional = false, HasTag = true, Tag = 17, HasDefaultValue = false)]
        public DeleteEventConditionList_Request DeleteECL
        {
            get
            {
                return deleteECL_;
            }
            set
            {
                selectDeleteECL(value);
            }
        }


        [ASN1Element(Name = "addECLReference", IsOptional = false, HasTag = true, Tag = 18, HasDefaultValue = false)]
        public AddEventConditionListReference_Request AddECLReference
        {
            get
            {
                return addECLReference_;
            }
            set
            {
                selectAddECLReference(value);
            }
        }


        [ASN1Element(Name = "removeECLReference", IsOptional = false, HasTag = true, Tag = 19, HasDefaultValue = false)]
        public RemoveEventConditionListReference_Request RemoveECLReference
        {
            get
            {
                return removeECLReference_;
            }
            set
            {
                selectRemoveECLReference(value);
            }
        }


        [ASN1Element(Name = "getECLAttributes", IsOptional = false, HasTag = true, Tag = 20, HasDefaultValue = false)]
        public GetEventConditionListAttributes_Request GetECLAttributes
        {
            get
            {
                return getECLAttributes_;
            }
            set
            {
                selectGetECLAttributes(value);
            }
        }


        [ASN1Element(Name = "reportECLStatus", IsOptional = false, HasTag = true, Tag = 21, HasDefaultValue = false)]
        public ReportEventConditionListStatus_Request ReportECLStatus
        {
            get
            {
                return reportECLStatus_;
            }
            set
            {
                selectReportECLStatus(value);
            }
        }


        [ASN1Element(Name = "alterECLMonitoring", IsOptional = false, HasTag = true, Tag = 22, HasDefaultValue = false)]
        public AlterEventConditionListMonitoring_Request AlterECLMonitoring
        {
            get
            {
                return alterECLMonitoring_;
            }
            set
            {
                selectAlterECLMonitoring(value);
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


        public bool isVMDStopSelected()
        {
            return vMDStop_selected;
        }


        public void selectVMDStop(VMDStop_Request val)
        {
            vMDStop_ = val;
            vMDStop_selected = true;


            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isVMDResetSelected()
        {
            return vMDReset_selected;
        }


        public void selectVMDReset(VMDReset_Request val)
        {
            vMDReset_ = val;
            vMDReset_selected = true;


            vMDStop_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isSelectSelected()
        {
            return select_selected;
        }


        public void selectSelect(Select_Request val)
        {
            select_ = val;
            select_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isAlterPISelected()
        {
            return alterPI_selected;
        }


        public void selectAlterPI(AlterProgramInvocationAttributes_Request val)
        {
            alterPI_ = val;
            alterPI_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isInitiateUCLoadSelected()
        {
            return initiateUCLoad_selected;
        }


        public void selectInitiateUCLoad(InitiateUnitControlLoad_Request val)
        {
            initiateUCLoad_ = val;
            initiateUCLoad_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isUCLoadSelected()
        {
            return uCLoad_selected;
        }


        public void selectUCLoad(UnitControlLoadSegment_Request val)
        {
            uCLoad_ = val;
            uCLoad_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isUCUploadSelected()
        {
            return uCUpload_selected;
        }


        public void selectUCUpload(UnitControlUpload_Request val)
        {
            uCUpload_ = val;
            uCUpload_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isStartUCSelected()
        {
            return startUC_selected;
        }


        public void selectStartUC(StartUnitControl_Request val)
        {
            startUC_ = val;
            startUC_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isStopUCSelected()
        {
            return stopUC_selected;
        }


        public void selectStopUC(StopUnitControl_Request val)
        {
            stopUC_ = val;
            stopUC_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isCreateUCSelected()
        {
            return createUC_selected;
        }


        public void selectCreateUC(CreateUnitControl_Request val)
        {
            createUC_ = val;
            createUC_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isAddToUCSelected()
        {
            return addToUC_selected;
        }


        public void selectAddToUC(AddToUnitControl_Request val)
        {
            addToUC_ = val;
            addToUC_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isRemoveFromUCSelected()
        {
            return removeFromUC_selected;
        }


        public void selectRemoveFromUC(RemoveFromUnitControl_Request val)
        {
            removeFromUC_ = val;
            removeFromUC_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isGetUCAttributesSelected()
        {
            return getUCAttributes_selected;
        }


        public void selectGetUCAttributes(GetUnitControlAttributes_Request val)
        {
            getUCAttributes_ = val;
            getUCAttributes_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isLoadUCFromFileSelected()
        {
            return loadUCFromFile_selected;
        }


        public void selectLoadUCFromFile(LoadUnitControlFromFile_Request val)
        {
            loadUCFromFile_ = val;
            loadUCFromFile_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isStoreUCToFileSelected()
        {
            return storeUCToFile_selected;
        }


        public void selectStoreUCToFile(StoreUnitControlToFile_Request val)
        {
            storeUCToFile_ = val;
            storeUCToFile_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isDeleteUCSelected()
        {
            return deleteUC_selected;
        }


        public void selectDeleteUC(DeleteUnitControl_Request val)
        {
            deleteUC_ = val;
            deleteUC_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isDefineECLSelected()
        {
            return defineECL_selected;
        }


        public void selectDefineECL(DefineEventConditionList_Request val)
        {
            defineECL_ = val;
            defineECL_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isDeleteECLSelected()
        {
            return deleteECL_selected;
        }


        public void selectDeleteECL(DeleteEventConditionList_Request val)
        {
            deleteECL_ = val;
            deleteECL_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isAddECLReferenceSelected()
        {
            return addECLReference_selected;
        }


        public void selectAddECLReference(AddEventConditionListReference_Request val)
        {
            addECLReference_ = val;
            addECLReference_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isRemoveECLReferenceSelected()
        {
            return removeECLReference_selected;
        }


        public void selectRemoveECLReference(RemoveEventConditionListReference_Request val)
        {
            removeECLReference_ = val;
            removeECLReference_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isGetECLAttributesSelected()
        {
            return getECLAttributes_selected;
        }


        public void selectGetECLAttributes(GetEventConditionListAttributes_Request val)
        {
            getECLAttributes_ = val;
            getECLAttributes_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            reportECLStatus_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isReportECLStatusSelected()
        {
            return reportECLStatus_selected;
        }


        public void selectReportECLStatus(ReportEventConditionListStatus_Request val)
        {
            reportECLStatus_ = val;
            reportECLStatus_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            alterECLMonitoring_selected = false;
        }


        public bool isAlterECLMonitoringSelected()
        {
            return alterECLMonitoring_selected;
        }


        public void selectAlterECLMonitoring(AlterEventConditionListMonitoring_Request val)
        {
            alterECLMonitoring_ = val;
            alterECLMonitoring_selected = true;


            vMDStop_selected = false;

            vMDReset_selected = false;

            select_selected = false;

            alterPI_selected = false;

            initiateUCLoad_selected = false;

            uCLoad_selected = false;

            uCUpload_selected = false;

            startUC_selected = false;

            stopUC_selected = false;

            createUC_selected = false;

            addToUC_selected = false;

            removeFromUC_selected = false;

            getUCAttributes_selected = false;

            loadUCFromFile_selected = false;

            storeUCToFile_selected = false;

            deleteUC_selected = false;

            defineECL_selected = false;

            deleteECL_selected = false;

            addECLReference_selected = false;

            removeECLReference_selected = false;

            getECLAttributes_selected = false;

            reportECLStatus_selected = false;
        }
    }
}