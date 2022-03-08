// GENERATED AUTOMATICALLY FROM 'Assets/InputAction/Controllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controllers : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""player"",
            ""id"": ""2a100861-52b0-43b5-994e-f87abb5788d3"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e57af8b-35c8-4d7e-9dc5-7c00aa27471d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c45e9048-25a6-4113-b638-e17f317509e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tripleShoot"",
                    ""type"": ""Button"",
                    ""id"": ""84fd978c-fdf7-44b7-bcf7-5310e94ff96a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""a75d895c-c06e-4245-b224-e93cb7754063"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""9aeaa1a4-0e8d-4d79-ae2a-3b6b2133a93a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""stopMusic"",
                    ""type"": ""Button"",
                    ""id"": ""f80c4f7f-c632-4ee6-a6d7-d5188f4fb133"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""playMusic"",
                    ""type"": ""Button"",
                    ""id"": ""982af7ac-2c26-4247-9d6a-bb2fa01d8e45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""b9dfa415-481f-4049-b06c-0db6075825d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""2903c791-cc8c-45db-9e7f-580edb9076d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale1"",
                    ""type"": ""Button"",
                    ""id"": ""794c45ac-c182-4941-b40b-cbb7392ef8f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale0"",
                    ""type"": ""Button"",
                    ""id"": ""59e664f0-e0c2-457e-8aaf-68f03dd5c08d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0da01cc4-a52a-49ba-9b5c-fc239555c27c"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4632602e-ddbb-4668-807e-0172c2aff959"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9ca189db-cee6-4f26-a6b0-4b4af3e25ec4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""41b80a52-1d1a-4421-9611-1c710eedec96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d22eecc-e38c-4727-bc98-dcb91d60cd2c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bf1dc8f3-cc0f-416c-9258-f60d0559cc78"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""69f1b443-c617-4934-9dab-5137c6fe991d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f43f97a-7715-4301-a9be-75de17ca188a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22fcb377-4eb7-4f09-8796-c5c41959db5c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e9447d2-9ae3-4142-a034-dce8870a9349"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""976aeddd-7448-460a-b1c7-956be8f7c4e0"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3be0eb3d-3942-4381-b9d3-d9b0e754d90d"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c650273d-b315-48e1-a94b-b075f32fb4dc"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""888fe1d5-48fc-4fd5-9ecf-03040468c25b"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d543e532-1a39-447c-81c9-2afa000c214b"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2897965d-9f2e-459b-9672-8969bccaf4ab"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""344e68a4-a6bb-46fd-81ba-7b38f54dadbb"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""439c49f5-7cec-4b51-af9d-b9d184a04dc6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9be41095-fc0d-471b-80e5-9a282af2ec66"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cad28fc0-cc3c-4845-a9e6-2f370cbe1531"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39736c44-619b-413b-882e-5e80d3c2cdf3"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8ab1e7a-a8ad-4d0d-b490-c1f81f7a9694"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""player1"",
            ""id"": ""515a3e62-b690-41aa-9de7-52414c234ca6"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18e18eaf-52c1-4784-9056-5ed386bedf39"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""ea55b26a-b2b0-4402-b3dc-5d671b40ad3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tripleShoot"",
                    ""type"": ""Button"",
                    ""id"": ""e2aa3230-097d-4ab4-b83f-4d328dc9f0fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""0a99b43f-6419-4afa-b0e5-7f85bd572fd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""933a1e07-0fc8-4a03-a1f2-911eb90eddb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""stopMusic"",
                    ""type"": ""Button"",
                    ""id"": ""a08326b5-2d30-4684-9f48-3a8c5896a75e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""playMusic"",
                    ""type"": ""Button"",
                    ""id"": ""04043cc0-6ad3-4bcb-9caf-ebf23df89ac4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""a7a0af96-0d53-4c4d-ae2e-be832899142d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""dac204a6-2eaa-4a8e-85a5-99235f390c85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale1"",
                    ""type"": ""Button"",
                    ""id"": ""347881cb-ee30-46fe-bfed-047ff44d8897"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale0"",
                    ""type"": ""Button"",
                    ""id"": ""93daac2d-5e64-4f34-9e6b-a1d0a989f5b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""45b2f070-fdfd-45a2-befa-d139b9634650"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcc71abe-7666-45ab-a56e-1deb9c6f008d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dcd595b3-2296-47ab-a53a-71bc170b36e6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8ee68748-c050-4ec2-be96-be0fa9dd617d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f0ceb7a-60c0-48be-bb09-fd4496c1adf7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e66967d3-2f9c-4182-8478-804bc6fd26e8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8dad897b-c24e-4416-8866-372c1398c877"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e1763312-d1f6-4aa8-b305-cfab95737e38"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70133368-58d0-4a59-8389-e4464d4846df"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c96819f-8bae-4462-9ea5-782f98edc82d"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33a9c6ce-67df-4057-95a2-387de7ad17cb"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a42b5145-2f35-414a-be87-39066ac156b9"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0590e64-a6d7-49c4-9348-287ef252f175"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee72c204-aea5-41ea-bdb2-acdf6a641d21"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13b6cc0c-1c9d-4bdd-926b-f82b00b93c9e"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61eeb8d7-a4ec-42c0-aeda-f5d96ce05b2d"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""914959c0-782e-4615-b545-411b76fddfbe"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd2e1ade-4d63-43b8-92af-2d70658c8958"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da61de54-a099-4132-97a7-12c17420c195"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13505b5a-1f41-4fec-9c23-a27d9ac85d14"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10337b16-29e9-463a-b798-5333a81c64ad"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ae801b7-0c99-4cbf-8568-531cadae1f11"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""player2"",
            ""id"": ""08cafd99-73ea-4d17-8386-eaea902484bb"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6b2688dd-0067-49a2-ae0f-98a1adf56a2f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""shoot"",
                    ""type"": ""Button"",
                    ""id"": ""008db052-a8dc-49f6-aaa2-a20488930da2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""tripleShoot"",
                    ""type"": ""Button"",
                    ""id"": ""31a35c69-1d46-43f8-8b7e-9619ac27687e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""2a6f9dfc-79e6-4078-8d5a-7e8f93d65bd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""fc5eb378-35a4-4b4c-8a89-af2436025b2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""stopMusic"",
                    ""type"": ""Button"",
                    ""id"": ""ab59800c-a971-4397-91c9-e9e0300a00a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""playMusic"",
                    ""type"": ""Button"",
                    ""id"": ""6f0ab8d3-a383-487c-84f7-f7a92c09fd5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""43fb03a3-79e4-4a63-9a76-3eefd18bc213"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""d1665f71-5afa-48b8-a62c-25101619455a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale1"",
                    ""type"": ""Button"",
                    ""id"": ""258d4e17-c911-4c41-bc96-bc7d2aee741c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale0"",
                    ""type"": ""Button"",
                    ""id"": ""502bb4d9-22dd-47f2-833f-940bc429a461"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7228b100-7249-4837-a76e-9a644b9a6799"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc76eddb-9dc9-401b-ab71-dbfd7c4346b5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dbae255f-6abb-4935-bf97-f2a0f675c201"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c9f17b39-4f58-486c-8615-6cfd6a31c5ef"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc3d6f56-e228-4d66-b509-4da9cce8fa46"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d24a965c-333b-4698-b2c1-6b8273ab5036"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""696aef51-3976-43c5-a96e-b3ef3fa5bb98"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f8a89079-6ec1-483b-94f1-3dc4a3baa87e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1930270-5ff0-4003-ad61-e23c6cba766c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8af578d-9171-4702-8e4c-d495de0fd2e0"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1185c6f8-3b75-48b4-bcd4-67ca376b2d5e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcf5f907-9236-49b9-a9d8-2c36283666de"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72b0eaaa-f0af-44c5-9cbb-8c566d6446d5"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b858220-c67b-42de-a027-47cf71e4ca50"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""stopMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4483d570-5659-4f93-821e-9e197ce6bcbe"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25fc15ac-d5bc-4ae4-8c97-d584eee35fe3"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""playMusic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e846b7f-7070-4efa-b1ab-f9186474cc01"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6d56dc9-7cc4-4e17-b3e3-8bacde3d88b4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""tripleShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db1c38b3-c3fa-448f-9f5f-95b85091498b"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa080560-ae87-4f3e-83ef-d6749a9aceeb"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a26326-3a04-4d99-b0db-7e14bff02565"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7b62290-6f4a-4b93-8dd9-2d0555875eaf"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // player
        m_player = asset.FindActionMap("player", throwIfNotFound: true);
        m_player_move = m_player.FindAction("move", throwIfNotFound: true);
        m_player_shoot = m_player.FindAction("shoot", throwIfNotFound: true);
        m_player_tripleShoot = m_player.FindAction("tripleShoot", throwIfNotFound: true);
        m_player_pause = m_player.FindAction("pause", throwIfNotFound: true);
        m_player_Resume = m_player.FindAction("Resume", throwIfNotFound: true);
        m_player_stopMusic = m_player.FindAction("stopMusic", throwIfNotFound: true);
        m_player_playMusic = m_player.FindAction("playMusic", throwIfNotFound: true);
        m_player_disableCheatDamage = m_player.FindAction("disableCheatDamage", throwIfNotFound: true);
        m_player_enableCheatDamage = m_player.FindAction("enableCheatDamage", throwIfNotFound: true);
        m_player_timeScale1 = m_player.FindAction("timeScale1", throwIfNotFound: true);
        m_player_timeScale0 = m_player.FindAction("timeScale0", throwIfNotFound: true);
        // player1
        m_player1 = asset.FindActionMap("player1", throwIfNotFound: true);
        m_player1_move = m_player1.FindAction("move", throwIfNotFound: true);
        m_player1_shoot = m_player1.FindAction("shoot", throwIfNotFound: true);
        m_player1_tripleShoot = m_player1.FindAction("tripleShoot", throwIfNotFound: true);
        m_player1_pause = m_player1.FindAction("pause", throwIfNotFound: true);
        m_player1_Resume = m_player1.FindAction("Resume", throwIfNotFound: true);
        m_player1_stopMusic = m_player1.FindAction("stopMusic", throwIfNotFound: true);
        m_player1_playMusic = m_player1.FindAction("playMusic", throwIfNotFound: true);
        m_player1_disableCheatDamage = m_player1.FindAction("disableCheatDamage", throwIfNotFound: true);
        m_player1_enableCheatDamage = m_player1.FindAction("enableCheatDamage", throwIfNotFound: true);
        m_player1_timeScale1 = m_player1.FindAction("timeScale1", throwIfNotFound: true);
        m_player1_timeScale0 = m_player1.FindAction("timeScale0", throwIfNotFound: true);
        // player2
        m_player2 = asset.FindActionMap("player2", throwIfNotFound: true);
        m_player2_move = m_player2.FindAction("move", throwIfNotFound: true);
        m_player2_shoot = m_player2.FindAction("shoot", throwIfNotFound: true);
        m_player2_tripleShoot = m_player2.FindAction("tripleShoot", throwIfNotFound: true);
        m_player2_pause = m_player2.FindAction("pause", throwIfNotFound: true);
        m_player2_Resume = m_player2.FindAction("Resume", throwIfNotFound: true);
        m_player2_stopMusic = m_player2.FindAction("stopMusic", throwIfNotFound: true);
        m_player2_playMusic = m_player2.FindAction("playMusic", throwIfNotFound: true);
        m_player2_disableCheatDamage = m_player2.FindAction("disableCheatDamage", throwIfNotFound: true);
        m_player2_enableCheatDamage = m_player2.FindAction("enableCheatDamage", throwIfNotFound: true);
        m_player2_timeScale1 = m_player2.FindAction("timeScale1", throwIfNotFound: true);
        m_player2_timeScale0 = m_player2.FindAction("timeScale0", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // player
    private readonly InputActionMap m_player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_player_move;
    private readonly InputAction m_player_shoot;
    private readonly InputAction m_player_tripleShoot;
    private readonly InputAction m_player_pause;
    private readonly InputAction m_player_Resume;
    private readonly InputAction m_player_stopMusic;
    private readonly InputAction m_player_playMusic;
    private readonly InputAction m_player_disableCheatDamage;
    private readonly InputAction m_player_enableCheatDamage;
    private readonly InputAction m_player_timeScale1;
    private readonly InputAction m_player_timeScale0;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputAction @tripleShoot => m_Wrapper.m_player_tripleShoot;
        public InputAction @pause => m_Wrapper.m_player_pause;
        public InputAction @Resume => m_Wrapper.m_player_Resume;
        public InputAction @stopMusic => m_Wrapper.m_player_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player_playMusic;
        public InputAction @disableCheatDamage => m_Wrapper.m_player_disableCheatDamage;
        public InputAction @enableCheatDamage => m_Wrapper.m_player_enableCheatDamage;
        public InputAction @timeScale1 => m_Wrapper.m_player_timeScale1;
        public InputAction @timeScale0 => m_Wrapper.m_player_timeScale0;
        public InputActionMap Get() { return m_Wrapper.m_player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                @tripleShoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTripleShoot;
                @pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Resume.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @stopMusic.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMusic;
                @stopMusic.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMusic;
                @stopMusic.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStopMusic;
                @playMusic.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayMusic;
                @playMusic.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayMusic;
                @playMusic.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlayMusic;
                @disableCheatDamage.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisableCheatDamage;
                @enableCheatDamage.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableCheatDamage;
                @timeScale1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTimeScale1;
                @timeScale1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTimeScale1;
                @timeScale1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTimeScale1;
                @timeScale0.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTimeScale0;
                @timeScale0.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTimeScale0;
                @timeScale0.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTimeScale0;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
                @tripleShoot.started += instance.OnTripleShoot;
                @tripleShoot.performed += instance.OnTripleShoot;
                @tripleShoot.canceled += instance.OnTripleShoot;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @stopMusic.started += instance.OnStopMusic;
                @stopMusic.performed += instance.OnStopMusic;
                @stopMusic.canceled += instance.OnStopMusic;
                @playMusic.started += instance.OnPlayMusic;
                @playMusic.performed += instance.OnPlayMusic;
                @playMusic.canceled += instance.OnPlayMusic;
                @disableCheatDamage.started += instance.OnDisableCheatDamage;
                @disableCheatDamage.performed += instance.OnDisableCheatDamage;
                @disableCheatDamage.canceled += instance.OnDisableCheatDamage;
                @enableCheatDamage.started += instance.OnEnableCheatDamage;
                @enableCheatDamage.performed += instance.OnEnableCheatDamage;
                @enableCheatDamage.canceled += instance.OnEnableCheatDamage;
                @timeScale1.started += instance.OnTimeScale1;
                @timeScale1.performed += instance.OnTimeScale1;
                @timeScale1.canceled += instance.OnTimeScale1;
                @timeScale0.started += instance.OnTimeScale0;
                @timeScale0.performed += instance.OnTimeScale0;
                @timeScale0.canceled += instance.OnTimeScale0;
            }
        }
    }
    public PlayerActions @player => new PlayerActions(this);

    // player1
    private readonly InputActionMap m_player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_player1_move;
    private readonly InputAction m_player1_shoot;
    private readonly InputAction m_player1_tripleShoot;
    private readonly InputAction m_player1_pause;
    private readonly InputAction m_player1_Resume;
    private readonly InputAction m_player1_stopMusic;
    private readonly InputAction m_player1_playMusic;
    private readonly InputAction m_player1_disableCheatDamage;
    private readonly InputAction m_player1_enableCheatDamage;
    private readonly InputAction m_player1_timeScale1;
    private readonly InputAction m_player1_timeScale0;
    public struct Player1Actions
    {
        private @Controllers m_Wrapper;
        public Player1Actions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player1_move;
        public InputAction @shoot => m_Wrapper.m_player1_shoot;
        public InputAction @tripleShoot => m_Wrapper.m_player1_tripleShoot;
        public InputAction @pause => m_Wrapper.m_player1_pause;
        public InputAction @Resume => m_Wrapper.m_player1_Resume;
        public InputAction @stopMusic => m_Wrapper.m_player1_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player1_playMusic;
        public InputAction @disableCheatDamage => m_Wrapper.m_player1_disableCheatDamage;
        public InputAction @enableCheatDamage => m_Wrapper.m_player1_enableCheatDamage;
        public InputAction @timeScale1 => m_Wrapper.m_player1_timeScale1;
        public InputAction @timeScale0 => m_Wrapper.m_player1_timeScale0;
        public InputActionMap Get() { return m_Wrapper.m_player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMove;
                @shoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnShoot;
                @tripleShoot.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTripleShoot;
                @pause.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Resume.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnResume;
                @stopMusic.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStopMusic;
                @stopMusic.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStopMusic;
                @stopMusic.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStopMusic;
                @playMusic.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlayMusic;
                @playMusic.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlayMusic;
                @playMusic.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlayMusic;
                @disableCheatDamage.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableCheatDamage;
                @enableCheatDamage.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableCheatDamage;
                @timeScale1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale1;
                @timeScale0.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale0;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
                @tripleShoot.started += instance.OnTripleShoot;
                @tripleShoot.performed += instance.OnTripleShoot;
                @tripleShoot.canceled += instance.OnTripleShoot;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @stopMusic.started += instance.OnStopMusic;
                @stopMusic.performed += instance.OnStopMusic;
                @stopMusic.canceled += instance.OnStopMusic;
                @playMusic.started += instance.OnPlayMusic;
                @playMusic.performed += instance.OnPlayMusic;
                @playMusic.canceled += instance.OnPlayMusic;
                @disableCheatDamage.started += instance.OnDisableCheatDamage;
                @disableCheatDamage.performed += instance.OnDisableCheatDamage;
                @disableCheatDamage.canceled += instance.OnDisableCheatDamage;
                @enableCheatDamage.started += instance.OnEnableCheatDamage;
                @enableCheatDamage.performed += instance.OnEnableCheatDamage;
                @enableCheatDamage.canceled += instance.OnEnableCheatDamage;
                @timeScale1.started += instance.OnTimeScale1;
                @timeScale1.performed += instance.OnTimeScale1;
                @timeScale1.canceled += instance.OnTimeScale1;
                @timeScale0.started += instance.OnTimeScale0;
                @timeScale0.performed += instance.OnTimeScale0;
                @timeScale0.canceled += instance.OnTimeScale0;
            }
        }
    }
    public Player1Actions @player1 => new Player1Actions(this);

    // player2
    private readonly InputActionMap m_player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_player2_move;
    private readonly InputAction m_player2_shoot;
    private readonly InputAction m_player2_tripleShoot;
    private readonly InputAction m_player2_pause;
    private readonly InputAction m_player2_Resume;
    private readonly InputAction m_player2_stopMusic;
    private readonly InputAction m_player2_playMusic;
    private readonly InputAction m_player2_disableCheatDamage;
    private readonly InputAction m_player2_enableCheatDamage;
    private readonly InputAction m_player2_timeScale1;
    private readonly InputAction m_player2_timeScale0;
    public struct Player2Actions
    {
        private @Controllers m_Wrapper;
        public Player2Actions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player2_move;
        public InputAction @shoot => m_Wrapper.m_player2_shoot;
        public InputAction @tripleShoot => m_Wrapper.m_player2_tripleShoot;
        public InputAction @pause => m_Wrapper.m_player2_pause;
        public InputAction @Resume => m_Wrapper.m_player2_Resume;
        public InputAction @stopMusic => m_Wrapper.m_player2_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player2_playMusic;
        public InputAction @disableCheatDamage => m_Wrapper.m_player2_disableCheatDamage;
        public InputAction @enableCheatDamage => m_Wrapper.m_player2_enableCheatDamage;
        public InputAction @timeScale1 => m_Wrapper.m_player2_timeScale1;
        public InputAction @timeScale0 => m_Wrapper.m_player2_timeScale0;
        public InputActionMap Get() { return m_Wrapper.m_player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @shoot.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnShoot;
                @shoot.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnShoot;
                @shoot.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnShoot;
                @tripleShoot.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTripleShoot;
                @tripleShoot.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTripleShoot;
                @pause.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPause;
                @Resume.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnResume;
                @stopMusic.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStopMusic;
                @stopMusic.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStopMusic;
                @stopMusic.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStopMusic;
                @playMusic.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPlayMusic;
                @playMusic.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPlayMusic;
                @playMusic.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPlayMusic;
                @disableCheatDamage.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableCheatDamage;
                @enableCheatDamage.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableCheatDamage;
                @timeScale1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale1;
                @timeScale0.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale0;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @shoot.started += instance.OnShoot;
                @shoot.performed += instance.OnShoot;
                @shoot.canceled += instance.OnShoot;
                @tripleShoot.started += instance.OnTripleShoot;
                @tripleShoot.performed += instance.OnTripleShoot;
                @tripleShoot.canceled += instance.OnTripleShoot;
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @stopMusic.started += instance.OnStopMusic;
                @stopMusic.performed += instance.OnStopMusic;
                @stopMusic.canceled += instance.OnStopMusic;
                @playMusic.started += instance.OnPlayMusic;
                @playMusic.performed += instance.OnPlayMusic;
                @playMusic.canceled += instance.OnPlayMusic;
                @disableCheatDamage.started += instance.OnDisableCheatDamage;
                @disableCheatDamage.performed += instance.OnDisableCheatDamage;
                @disableCheatDamage.canceled += instance.OnDisableCheatDamage;
                @enableCheatDamage.started += instance.OnEnableCheatDamage;
                @enableCheatDamage.performed += instance.OnEnableCheatDamage;
                @enableCheatDamage.canceled += instance.OnEnableCheatDamage;
                @timeScale1.started += instance.OnTimeScale1;
                @timeScale1.performed += instance.OnTimeScale1;
                @timeScale1.canceled += instance.OnTimeScale1;
                @timeScale0.started += instance.OnTimeScale0;
                @timeScale0.performed += instance.OnTimeScale0;
                @timeScale0.canceled += instance.OnTimeScale0;
            }
        }
    }
    public Player2Actions @player2 => new Player2Actions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTripleShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnDisableCheatDamage(InputAction.CallbackContext context);
        void OnEnableCheatDamage(InputAction.CallbackContext context);
        void OnTimeScale1(InputAction.CallbackContext context);
        void OnTimeScale0(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTripleShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnDisableCheatDamage(InputAction.CallbackContext context);
        void OnEnableCheatDamage(InputAction.CallbackContext context);
        void OnTimeScale1(InputAction.CallbackContext context);
        void OnTimeScale0(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTripleShoot(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnDisableCheatDamage(InputAction.CallbackContext context);
        void OnEnableCheatDamage(InputAction.CallbackContext context);
        void OnTimeScale1(InputAction.CallbackContext context);
        void OnTimeScale0(InputAction.CallbackContext context);
    }
}
