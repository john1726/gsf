'***********************************************************************
'  IChannel.vb - Channel interface - this is the root interface
'  Copyright � 2005 - TVA, all rights reserved
'
'  Build Environment: VB.NET, Visual Studio 2003
'  Primary Developer: James R Carroll, System Analyst [TVA]
'      Office: COO - TRNS/PWR ELEC SYS O, CHATTANOOGA, TN - MR 2W-C
'       Phone: 423/751-2827
'       Email: jrcarrol@tva.gov
'
'  Code Modification History:
'  ---------------------------------------------------------------------
'  02/18/2005 - James R Carroll
'       Initial version of source generated
'
'***********************************************************************

Namespace EE.Phasor

    ' This interface represents a protocol independent representation of any data type.
    Public Interface IChannel

        ReadOnly Property InheritedType() As Type

        ReadOnly Property This() As IChannel

        ReadOnly Property BinaryLength() As Int16

        ReadOnly Property BinaryImage() As Byte()

        ' These are typically implemented as protected properties that collectively feed the public binary properties
        ReadOnly Property HeaderLength() As Int16

        ReadOnly Property HeaderImage() As Byte()

        ' The body properties are typically implemented by the base classes defining the "common" data image set
        ReadOnly Property BodyLength() As Int16

        ReadOnly Property BodyImage() As Byte()

        ReadOnly Property FooterLength() As Int16

        ReadOnly Property FooterImage() As Byte()

    End Interface

End Namespace
