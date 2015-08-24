'*******************************************************************************************************
'  PhasorValue.vb - Phasor value
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
'  11/12/2004 - J. Ritchie Carroll
'       Initial version of source generated
'
'*******************************************************************************************************

Imports System.Runtime.Serialization

Namespace Ieee1344

    <CLSCompliant(False), Serializable()> _
    Public Class PhasorValue

        Inherits PhasorValueBase

        Public Overloads Shared Function CreateFromPolarValues(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal angle As Single, ByVal magnitude As Single) As PhasorValue

            Return PhasorValueBase.CreateFromPolarValues(AddressOf CreateNewPhasorValue, parent, phasorDefinition, angle, magnitude)

        End Function

        Public Overloads Shared Function CreateFromRectangularValues(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal real As Single, ByVal imaginary As Single) As PhasorValue

            Return PhasorValueBase.CreateFromRectangularValues(AddressOf CreateNewPhasorValue, parent, phasorDefinition, real, imaginary)

        End Function

        Public Overloads Shared Function CreateFromUnscaledRectangularValues(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal real As Int16, ByVal imaginary As Int16) As PhasorValue

            Return PhasorValueBase.CreateFromUnscaledRectangularValues(AddressOf CreateNewPhasorValue, parent, phasorDefinition, real, imaginary)

        End Function

        Private Shared Function CreateNewPhasorValue(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal real As Single, ByVal imaginary As Single) As IPhasorValue

            Return New PhasorValue(parent, phasorDefinition, real, imaginary)

        End Function

        Protected Sub New()
        End Sub

        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)

            MyBase.New(info, context)

        End Sub

        Public Sub New(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal real As Single, ByVal imaginary As Single)

            MyBase.New(parent, phasorDefinition, real, imaginary)

        End Sub

        Public Sub New(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal unscaledReal As Int16, ByVal unscaledImaginary As Int16)

            MyBase.New(parent, phasorDefinition, unscaledReal, unscaledImaginary)

        End Sub

        Public Sub New(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal binaryImage As Byte(), ByVal startIndex As Int32)

            MyBase.New(parent, phasorDefinition, binaryImage, startIndex)

        End Sub

        Public Sub New(ByVal parent As IDataCell, ByVal phasorDefinition As IPhasorDefinition, ByVal phasorValue As IPhasorValue)

            MyBase.New(parent, phasorDefinition, phasorValue)

        End Sub

        Friend Shared Function CreateNewPhasorValue(ByVal parent As IDataCell, ByVal definition As IPhasorDefinition, ByVal binaryImage As Byte(), ByVal startIndex As Int32) As IPhasorValue

            Return New PhasorValue(parent, definition, binaryImage, startIndex)

        End Function

        Public Overrides ReadOnly Property DerivedType() As System.Type
            Get
                Return Me.GetType()
            End Get
        End Property

        Public Shadows ReadOnly Property Parent() As DataCell
            Get
                Return MyBase.Parent
            End Get
        End Property

        Public Shadows Property Definition() As PhasorDefinition
            Get
                Return MyBase.Definition
            End Get
            Set(ByVal value As PhasorDefinition)
                MyBase.Definition = value
            End Set
        End Property

    End Class

End Namespace