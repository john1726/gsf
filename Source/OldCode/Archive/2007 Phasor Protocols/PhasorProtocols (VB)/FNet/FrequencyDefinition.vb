'*******************************************************************************************************
'  FrequencyDefinition.vb - FNet Frequency definition
'  Copyright � 2008 - TVA, all rights reserved - Gbtc
'
'  Build Environment: VB.NET, Visual Studio 2008
'  Primary Developer: J. Ritchie Carroll, Operations Data Architecture [TVA]
'      Office: COO - TRNS/PWR ELEC SYS O, CHATTANOOGA, TN - MR 2W-C
'       Phone: 423/751-2827
'       Email: jrcarrol@tva.gov
'
'  Code Modification History:
'  -----------------------------------------------------------------------------------------------------
'  02/08/2007 - J. Ritchie Carroll & Jian (Ryan) Zuo
'       Initial version of source generated
'
'*******************************************************************************************************

Imports System.Runtime.Serialization

Namespace FNet

    <CLSCompliant(False), Serializable()> _
    Public Class FrequencyDefinition

        Inherits FrequencyDefinitionBase

        Protected Sub New()
        End Sub

        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)

            MyBase.New(info, context)

        End Sub

        Public Sub New(ByVal parent As ConfigurationCell)

            MyBase.New(parent)

        End Sub

        Public Sub New(ByVal parent As ConfigurationCell, ByVal label As String, ByVal scale As Int32, ByVal offset As Single, ByVal dfdtScale As Int32, ByVal dfdtOffset As Single)

            MyBase.New(parent, label, scale, offset, dfdtScale, dfdtOffset)

        End Sub

        Public Sub New(ByVal parent As ConfigurationCell, ByVal frequencyDefinition As IFrequencyDefinition)

            MyBase.New(parent, frequencyDefinition)

        End Sub

        ' FNet supports no configuration frame in the data stream - so there will be nothing to parse
        'Public Sub New(ByVal parent As ConfigurationCell, ByVal binaryImage As Byte(), ByVal startIndex As Int32)

        '    MyBase.New(parent, binaryImage, startIndex)

        'End Sub

        'Friend Shared Function CreateNewFrequencyDefintion(ByVal parent As IConfigurationCell, ByVal binaryImage As Byte(), ByVal startIndex As Int32) As IFrequencyDefinition

        '    Return New FrequencyDefinition(parent, binaryImage, startIndex)

        'End Function

        Public Overrides ReadOnly Property DerivedType() As System.Type
            Get
                Return Me.GetType
            End Get
        End Property

        Public Shadows ReadOnly Property Parent() As ConfigurationCell
            Get
                Return MyBase.Parent
            End Get
        End Property

    End Class

End Namespace