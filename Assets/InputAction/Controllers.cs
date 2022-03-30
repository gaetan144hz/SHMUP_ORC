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
                },
                {
                    ""name"": ""removeHealth"",
                    ""type"": ""Button"",
                    ""id"": ""21f5f4bd-5e2b-4569-8e44-bc5d20d38079"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""maxHealth"",
                    ""type"": ""Button"",
                    ""id"": ""33fb4689-b2ca-4128-92a3-6fde61911539"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""maxSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""93f81ad4-6b8a-4ff4-9569-a219fea94596"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""removeSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""aeb489ae-78e3-42b7-ae3c-85063b178e5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableDisqueSpwn"",
                    ""type"": ""Button"",
                    ""id"": ""6df8211e-43d0-41aa-82e6-ca3d4b78d1d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableDisqueSpwn"",
                    ""type"": ""Button"",
                    ""id"": ""fa74194e-1bae-4901-a919-3192c51e428c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""92f2864f-1e41-4586-9e3b-206298b45610"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""3148b2fe-9393-46ab-9654-1e5f070637b1"",
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
                    ""name"": ""2D Vector AZERTY"",
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
                    ""path"": ""<Keyboard>/f1"",
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
                    ""path"": ""<Keyboard>/f6"",
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
                    ""path"": ""<Keyboard>/f5"",
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
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3f177fd-a975-4f41-87ad-c261f560eb8d"",
                    ""path"": ""<Keyboard>/f4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""removeHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d2f22b6-1317-42c4-8b25-d15687fd341c"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""maxHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7c57b91-17a4-41a1-bc2a-df37acb68fd4"",
                    ""path"": ""<Keyboard>/f7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""maxSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f05143bd-dc1d-4995-bae4-def7989b82b8"",
                    ""path"": ""<Keyboard>/f8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""removeSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9ffe52f-e01a-4340-add6-b03a7af544e5"",
                    ""path"": ""<Keyboard>/f10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableDisqueSpwn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe67f427-ca43-4fea-8fe1-f02c21a05026"",
                    ""path"": ""<Keyboard>/f9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableDisqueSpwn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f7f06e4-2c94-483d-9444-1ff0165e98a5"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89e26b51-0f9d-477d-8762-96306974e03f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector Arrow"",
                    ""id"": ""ae65f175-f0e9-49f0-9854-2a497b037441"",
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
                    ""id"": ""47cb57ec-076c-49b7-bf1a-64a9d7d9145e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3771109-76f6-4248-9870-83401725b3e3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d3859b49-057c-4402-86ec-54e23eb7dcb2"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""238ca519-64aa-4b91-889d-2dcf8af11175"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""23901df4-630f-4a20-8a45-11a716ae0f5b"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67d14a92-d309-409d-8b77-4b351d3efe08"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
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
                    ""name"": ""removeSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""9bbd4ab9-1d3a-4ad7-9fdb-c1c9811a172e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""maxSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""134524c9-c7e7-42a9-8179-4ace520125d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""maxHealth"",
                    ""type"": ""Button"",
                    ""id"": ""e3c1e5f5-4876-4ab2-911e-704018223cfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""removeHealth"",
                    ""type"": ""Button"",
                    ""id"": ""f991cc5f-b6bb-4309-937b-482289562834"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale0"",
                    ""type"": ""Button"",
                    ""id"": ""94c5c1b2-0699-46b0-926f-aef834e805d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale1"",
                    ""type"": ""Button"",
                    ""id"": ""8f0e0ce8-f999-47bd-bc83-cf6e8e93e41b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""baa305d7-9e46-4303-8318-546656478386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""369f8d1e-d0af-4d37-bbb9-c00ca2db2e03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableDisqueSpwn"",
                    ""type"": ""Button"",
                    ""id"": ""ad309977-8be0-45df-9331-c5b4a744e4e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableDisqueSpwn"",
                    ""type"": ""Button"",
                    ""id"": ""7e9f8b63-68d6-40d7-988a-44c274631751"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""8830f4c6-f611-4422-801e-264ce5a1a2c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""b396164e-0a6e-430e-aa81-ed0dd764564d"",
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
                    ""id"": ""a58542cc-341f-45f0-9777-c763d53f1d91"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb433034-3b17-4e8e-9553-216ca57b32b2"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3ed65d4-2fc8-47bc-aad2-84b1ae46db9a"",
                    ""path"": ""<Keyboard>/f6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03cd4c4a-1631-4b25-8d71-e50bddb03e68"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""809614a4-307e-4730-9763-ba1fcc902c5e"",
                    ""path"": ""<Keyboard>/f4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""removeHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47e9c03c-0b17-42d2-9e74-a6179dabc8ed"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""maxHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6360db5a-dfe1-4321-bb86-fde95629fae1"",
                    ""path"": ""<Keyboard>/f7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""maxSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd7e7c45-d245-449b-aa7e-a8a9ac6b31cc"",
                    ""path"": ""<Keyboard>/f8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""removeSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f93c86f2-ac1a-4e7a-9ecc-9361e74d6b5d"",
                    ""path"": ""<Keyboard>/f10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableDisqueSpwn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6d1220f-3c0c-4a41-b978-b489fa3bf770"",
                    ""path"": ""<Keyboard>/f9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableDisqueSpwn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector Arrow"",
                    ""id"": ""4d5865a3-b1a4-4dc4-a200-032fc6c2f8d4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""63648f22-f2f4-4784-839c-8799ab0207a4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ccb707a7-c0a8-4790-b2e2-33670be869c4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1bf07555-3b93-4593-8018-53e0571b7b12"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""964d7b2e-6c58-499b-a90b-d179f1e2d588"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""749d3c05-02c4-4e01-809e-b229075dedc7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""395b8aee-d094-42f9-82a2-e86dffe6c2e8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d2ef1a3-a76c-4bed-92f1-dcdada6767d7"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a9e3a1c-c261-41ed-935a-9ba203a750e9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
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
                    ""name"": ""removeSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""41f1513a-9ea8-40d1-aa19-0d77edf2e2d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""maxSpeed"",
                    ""type"": ""Button"",
                    ""id"": ""18f89313-33e5-4af4-a370-3c49e24260bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""maxHealth"",
                    ""type"": ""Button"",
                    ""id"": ""869448ad-b757-49fb-8774-580defdbacc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""removeHealth"",
                    ""type"": ""Button"",
                    ""id"": ""809cb712-fa7f-4fd2-ac4c-4145022bba5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale0"",
                    ""type"": ""Button"",
                    ""id"": ""5fc34934-c675-4080-a057-e7e3ea79aa3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""timeScale1"",
                    ""type"": ""Button"",
                    ""id"": ""572c6074-923a-40d3-a704-7f136cd832a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""29abd187-ddd1-409b-a519-0865238e9634"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableCheatDamage"",
                    ""type"": ""Button"",
                    ""id"": ""2b7980bc-e056-458d-821a-6a1d5cda6021"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""disableDisqueSpwn"",
                    ""type"": ""Button"",
                    ""id"": ""d4827702-ba2d-4cf7-8d66-cb619f3d9644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""enableDisqueSpwn"",
                    ""type"": ""Button"",
                    ""id"": ""a1078a78-bfda-4f18-ad6f-8045305ebd28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""55694742-9f82-41cd-94c3-c9cd812f50b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""7b4df49c-49d1-47af-847a-c7e9f9f6cef8"",
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
                    ""id"": ""665200ee-beb2-48fc-8425-1e484cdbb356"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5450835-3a7d-4fdd-b9ec-fc72415da5e3"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableCheatDamage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c122840a-db24-462a-9a94-86c4e93e25a9"",
                    ""path"": ""<Keyboard>/f6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d269079-a27d-4f47-ab9f-3eb633d2be40"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""timeScale0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7f39615-0d00-45d7-bc2f-efb227fdbe47"",
                    ""path"": ""<Keyboard>/f4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""removeHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cea8589a-dcdf-4b21-83e9-1c8493d6f8e9"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""maxHealth"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16f8fd5d-2168-440d-b557-06f8b6c88b02"",
                    ""path"": ""<Keyboard>/f7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""maxSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ca164b9-da0b-4213-a595-1835fbe4a410"",
                    ""path"": ""<Keyboard>/f8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""removeSpeed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b459165f-01a8-4c4e-928d-b25ac855aa46"",
                    ""path"": ""<Keyboard>/f10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""enableDisqueSpwn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95cd535c-17a1-46a9-871d-4a7e87793824"",
                    ""path"": ""<Keyboard>/f9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""disableDisqueSpwn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector Arrow"",
                    ""id"": ""a3d47b21-38f8-4e2b-8c10-348da7461edf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9871a240-c5b3-4b45-b370-d5eeafd97950"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""10add409-1168-4dd9-8de3-0d05e67dcdb7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ff04d963-b95a-4a4b-9224-b60e944f5a48"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2c12ad0a-0e42-41aa-abdf-a532105955a5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d153eb53-0372-47b4-9138-7022e6d229f7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b067075-0ff7-4928-9930-7e6c29f605e6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0b281b4-8b7b-43d4-bcc6-9981e6ba4d64"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b37cdd83-9852-4350-a7e1-cfbd04518021"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""52c39f83-b875-4c27-be35-d14684dbaee5"",
            ""actions"": [
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""eb675b3f-9d77-43d3-a30e-4991a3f09d9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3cd9a574-73da-4745-8b75-c7c2f331458a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""024cd763-ab27-42a5-9385-046a12dad382"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""click"",
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
                },
                {
                    ""devicePath"": ""<Mouse>"",
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
        m_player_stopMusic = m_player.FindAction("stopMusic", throwIfNotFound: true);
        m_player_playMusic = m_player.FindAction("playMusic", throwIfNotFound: true);
        m_player_disableCheatDamage = m_player.FindAction("disableCheatDamage", throwIfNotFound: true);
        m_player_enableCheatDamage = m_player.FindAction("enableCheatDamage", throwIfNotFound: true);
        m_player_timeScale1 = m_player.FindAction("timeScale1", throwIfNotFound: true);
        m_player_timeScale0 = m_player.FindAction("timeScale0", throwIfNotFound: true);
        m_player_removeHealth = m_player.FindAction("removeHealth", throwIfNotFound: true);
        m_player_maxHealth = m_player.FindAction("maxHealth", throwIfNotFound: true);
        m_player_maxSpeed = m_player.FindAction("maxSpeed", throwIfNotFound: true);
        m_player_removeSpeed = m_player.FindAction("removeSpeed", throwIfNotFound: true);
        m_player_enableDisqueSpwn = m_player.FindAction("enableDisqueSpwn", throwIfNotFound: true);
        m_player_disableDisqueSpwn = m_player.FindAction("disableDisqueSpwn", throwIfNotFound: true);
        m_player_Resume = m_player.FindAction("Resume", throwIfNotFound: true);
        m_player_Pause = m_player.FindAction("Pause", throwIfNotFound: true);
        // player1
        m_player1 = asset.FindActionMap("player1", throwIfNotFound: true);
        m_player1_move = m_player1.FindAction("move", throwIfNotFound: true);
        m_player1_shoot = m_player1.FindAction("shoot", throwIfNotFound: true);
        m_player1_tripleShoot = m_player1.FindAction("tripleShoot", throwIfNotFound: true);
        m_player1_stopMusic = m_player1.FindAction("stopMusic", throwIfNotFound: true);
        m_player1_playMusic = m_player1.FindAction("playMusic", throwIfNotFound: true);
        m_player1_removeSpeed = m_player1.FindAction("removeSpeed", throwIfNotFound: true);
        m_player1_maxSpeed = m_player1.FindAction("maxSpeed", throwIfNotFound: true);
        m_player1_maxHealth = m_player1.FindAction("maxHealth", throwIfNotFound: true);
        m_player1_removeHealth = m_player1.FindAction("removeHealth", throwIfNotFound: true);
        m_player1_timeScale0 = m_player1.FindAction("timeScale0", throwIfNotFound: true);
        m_player1_timeScale1 = m_player1.FindAction("timeScale1", throwIfNotFound: true);
        m_player1_enableCheatDamage = m_player1.FindAction("enableCheatDamage", throwIfNotFound: true);
        m_player1_disableCheatDamage = m_player1.FindAction("disableCheatDamage", throwIfNotFound: true);
        m_player1_disableDisqueSpwn = m_player1.FindAction("disableDisqueSpwn", throwIfNotFound: true);
        m_player1_enableDisqueSpwn = m_player1.FindAction("enableDisqueSpwn", throwIfNotFound: true);
        m_player1_Pause = m_player1.FindAction("Pause", throwIfNotFound: true);
        m_player1_Resume = m_player1.FindAction("Resume", throwIfNotFound: true);
        // player2
        m_player2 = asset.FindActionMap("player2", throwIfNotFound: true);
        m_player2_move = m_player2.FindAction("move", throwIfNotFound: true);
        m_player2_shoot = m_player2.FindAction("shoot", throwIfNotFound: true);
        m_player2_tripleShoot = m_player2.FindAction("tripleShoot", throwIfNotFound: true);
        m_player2_stopMusic = m_player2.FindAction("stopMusic", throwIfNotFound: true);
        m_player2_playMusic = m_player2.FindAction("playMusic", throwIfNotFound: true);
        m_player2_removeSpeed = m_player2.FindAction("removeSpeed", throwIfNotFound: true);
        m_player2_maxSpeed = m_player2.FindAction("maxSpeed", throwIfNotFound: true);
        m_player2_maxHealth = m_player2.FindAction("maxHealth", throwIfNotFound: true);
        m_player2_removeHealth = m_player2.FindAction("removeHealth", throwIfNotFound: true);
        m_player2_timeScale0 = m_player2.FindAction("timeScale0", throwIfNotFound: true);
        m_player2_timeScale1 = m_player2.FindAction("timeScale1", throwIfNotFound: true);
        m_player2_enableCheatDamage = m_player2.FindAction("enableCheatDamage", throwIfNotFound: true);
        m_player2_disableCheatDamage = m_player2.FindAction("disableCheatDamage", throwIfNotFound: true);
        m_player2_disableDisqueSpwn = m_player2.FindAction("disableDisqueSpwn", throwIfNotFound: true);
        m_player2_enableDisqueSpwn = m_player2.FindAction("enableDisqueSpwn", throwIfNotFound: true);
        m_player2_Pause = m_player2.FindAction("Pause", throwIfNotFound: true);
        m_player2_Resume = m_player2.FindAction("Resume", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_click = m_UI.FindAction("click", throwIfNotFound: true);
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
    private readonly InputAction m_player_stopMusic;
    private readonly InputAction m_player_playMusic;
    private readonly InputAction m_player_disableCheatDamage;
    private readonly InputAction m_player_enableCheatDamage;
    private readonly InputAction m_player_timeScale1;
    private readonly InputAction m_player_timeScale0;
    private readonly InputAction m_player_removeHealth;
    private readonly InputAction m_player_maxHealth;
    private readonly InputAction m_player_maxSpeed;
    private readonly InputAction m_player_removeSpeed;
    private readonly InputAction m_player_enableDisqueSpwn;
    private readonly InputAction m_player_disableDisqueSpwn;
    private readonly InputAction m_player_Resume;
    private readonly InputAction m_player_Pause;
    public struct PlayerActions
    {
        private @Controllers m_Wrapper;
        public PlayerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player_move;
        public InputAction @shoot => m_Wrapper.m_player_shoot;
        public InputAction @tripleShoot => m_Wrapper.m_player_tripleShoot;
        public InputAction @stopMusic => m_Wrapper.m_player_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player_playMusic;
        public InputAction @disableCheatDamage => m_Wrapper.m_player_disableCheatDamage;
        public InputAction @enableCheatDamage => m_Wrapper.m_player_enableCheatDamage;
        public InputAction @timeScale1 => m_Wrapper.m_player_timeScale1;
        public InputAction @timeScale0 => m_Wrapper.m_player_timeScale0;
        public InputAction @removeHealth => m_Wrapper.m_player_removeHealth;
        public InputAction @maxHealth => m_Wrapper.m_player_maxHealth;
        public InputAction @maxSpeed => m_Wrapper.m_player_maxSpeed;
        public InputAction @removeSpeed => m_Wrapper.m_player_removeSpeed;
        public InputAction @enableDisqueSpwn => m_Wrapper.m_player_enableDisqueSpwn;
        public InputAction @disableDisqueSpwn => m_Wrapper.m_player_disableDisqueSpwn;
        public InputAction @Resume => m_Wrapper.m_player_Resume;
        public InputAction @Pause => m_Wrapper.m_player_Pause;
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
                @removeHealth.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveHealth;
                @removeHealth.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveHealth;
                @removeHealth.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveHealth;
                @maxHealth.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxHealth;
                @maxHealth.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxHealth;
                @maxHealth.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxHealth;
                @maxSpeed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxSpeed;
                @maxSpeed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxSpeed;
                @maxSpeed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMaxSpeed;
                @removeSpeed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveSpeed;
                @removeSpeed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveSpeed;
                @removeSpeed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRemoveSpeed;
                @enableDisqueSpwn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableDisqueSpwn;
                @enableDisqueSpwn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableDisqueSpwn;
                @enableDisqueSpwn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableDisqueSpwn;
                @disableDisqueSpwn.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisableDisqueSpwn;
                @disableDisqueSpwn.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisableDisqueSpwn;
                @disableDisqueSpwn.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDisableDisqueSpwn;
                @Resume.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
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
                @removeHealth.started += instance.OnRemoveHealth;
                @removeHealth.performed += instance.OnRemoveHealth;
                @removeHealth.canceled += instance.OnRemoveHealth;
                @maxHealth.started += instance.OnMaxHealth;
                @maxHealth.performed += instance.OnMaxHealth;
                @maxHealth.canceled += instance.OnMaxHealth;
                @maxSpeed.started += instance.OnMaxSpeed;
                @maxSpeed.performed += instance.OnMaxSpeed;
                @maxSpeed.canceled += instance.OnMaxSpeed;
                @removeSpeed.started += instance.OnRemoveSpeed;
                @removeSpeed.performed += instance.OnRemoveSpeed;
                @removeSpeed.canceled += instance.OnRemoveSpeed;
                @enableDisqueSpwn.started += instance.OnEnableDisqueSpwn;
                @enableDisqueSpwn.performed += instance.OnEnableDisqueSpwn;
                @enableDisqueSpwn.canceled += instance.OnEnableDisqueSpwn;
                @disableDisqueSpwn.started += instance.OnDisableDisqueSpwn;
                @disableDisqueSpwn.performed += instance.OnDisableDisqueSpwn;
                @disableDisqueSpwn.canceled += instance.OnDisableDisqueSpwn;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
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
    private readonly InputAction m_player1_stopMusic;
    private readonly InputAction m_player1_playMusic;
    private readonly InputAction m_player1_removeSpeed;
    private readonly InputAction m_player1_maxSpeed;
    private readonly InputAction m_player1_maxHealth;
    private readonly InputAction m_player1_removeHealth;
    private readonly InputAction m_player1_timeScale0;
    private readonly InputAction m_player1_timeScale1;
    private readonly InputAction m_player1_enableCheatDamage;
    private readonly InputAction m_player1_disableCheatDamage;
    private readonly InputAction m_player1_disableDisqueSpwn;
    private readonly InputAction m_player1_enableDisqueSpwn;
    private readonly InputAction m_player1_Pause;
    private readonly InputAction m_player1_Resume;
    public struct Player1Actions
    {
        private @Controllers m_Wrapper;
        public Player1Actions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player1_move;
        public InputAction @shoot => m_Wrapper.m_player1_shoot;
        public InputAction @tripleShoot => m_Wrapper.m_player1_tripleShoot;
        public InputAction @stopMusic => m_Wrapper.m_player1_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player1_playMusic;
        public InputAction @removeSpeed => m_Wrapper.m_player1_removeSpeed;
        public InputAction @maxSpeed => m_Wrapper.m_player1_maxSpeed;
        public InputAction @maxHealth => m_Wrapper.m_player1_maxHealth;
        public InputAction @removeHealth => m_Wrapper.m_player1_removeHealth;
        public InputAction @timeScale0 => m_Wrapper.m_player1_timeScale0;
        public InputAction @timeScale1 => m_Wrapper.m_player1_timeScale1;
        public InputAction @enableCheatDamage => m_Wrapper.m_player1_enableCheatDamage;
        public InputAction @disableCheatDamage => m_Wrapper.m_player1_disableCheatDamage;
        public InputAction @disableDisqueSpwn => m_Wrapper.m_player1_disableDisqueSpwn;
        public InputAction @enableDisqueSpwn => m_Wrapper.m_player1_enableDisqueSpwn;
        public InputAction @Pause => m_Wrapper.m_player1_Pause;
        public InputAction @Resume => m_Wrapper.m_player1_Resume;
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
                @stopMusic.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStopMusic;
                @stopMusic.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStopMusic;
                @stopMusic.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnStopMusic;
                @playMusic.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlayMusic;
                @playMusic.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlayMusic;
                @playMusic.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlayMusic;
                @removeSpeed.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRemoveSpeed;
                @removeSpeed.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRemoveSpeed;
                @removeSpeed.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRemoveSpeed;
                @maxSpeed.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMaxSpeed;
                @maxSpeed.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMaxSpeed;
                @maxSpeed.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMaxSpeed;
                @maxHealth.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMaxHealth;
                @maxHealth.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMaxHealth;
                @maxHealth.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMaxHealth;
                @removeHealth.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRemoveHealth;
                @removeHealth.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRemoveHealth;
                @removeHealth.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnRemoveHealth;
                @timeScale0.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale0;
                @timeScale1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnTimeScale1;
                @enableCheatDamage.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableCheatDamage;
                @disableCheatDamage.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableCheatDamage;
                @disableDisqueSpwn.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableDisqueSpwn;
                @disableDisqueSpwn.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableDisqueSpwn;
                @disableDisqueSpwn.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDisableDisqueSpwn;
                @enableDisqueSpwn.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableDisqueSpwn;
                @enableDisqueSpwn.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableDisqueSpwn;
                @enableDisqueSpwn.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnEnableDisqueSpwn;
                @Pause.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPause;
                @Resume.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnResume;
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
                @stopMusic.started += instance.OnStopMusic;
                @stopMusic.performed += instance.OnStopMusic;
                @stopMusic.canceled += instance.OnStopMusic;
                @playMusic.started += instance.OnPlayMusic;
                @playMusic.performed += instance.OnPlayMusic;
                @playMusic.canceled += instance.OnPlayMusic;
                @removeSpeed.started += instance.OnRemoveSpeed;
                @removeSpeed.performed += instance.OnRemoveSpeed;
                @removeSpeed.canceled += instance.OnRemoveSpeed;
                @maxSpeed.started += instance.OnMaxSpeed;
                @maxSpeed.performed += instance.OnMaxSpeed;
                @maxSpeed.canceled += instance.OnMaxSpeed;
                @maxHealth.started += instance.OnMaxHealth;
                @maxHealth.performed += instance.OnMaxHealth;
                @maxHealth.canceled += instance.OnMaxHealth;
                @removeHealth.started += instance.OnRemoveHealth;
                @removeHealth.performed += instance.OnRemoveHealth;
                @removeHealth.canceled += instance.OnRemoveHealth;
                @timeScale0.started += instance.OnTimeScale0;
                @timeScale0.performed += instance.OnTimeScale0;
                @timeScale0.canceled += instance.OnTimeScale0;
                @timeScale1.started += instance.OnTimeScale1;
                @timeScale1.performed += instance.OnTimeScale1;
                @timeScale1.canceled += instance.OnTimeScale1;
                @enableCheatDamage.started += instance.OnEnableCheatDamage;
                @enableCheatDamage.performed += instance.OnEnableCheatDamage;
                @enableCheatDamage.canceled += instance.OnEnableCheatDamage;
                @disableCheatDamage.started += instance.OnDisableCheatDamage;
                @disableCheatDamage.performed += instance.OnDisableCheatDamage;
                @disableCheatDamage.canceled += instance.OnDisableCheatDamage;
                @disableDisqueSpwn.started += instance.OnDisableDisqueSpwn;
                @disableDisqueSpwn.performed += instance.OnDisableDisqueSpwn;
                @disableDisqueSpwn.canceled += instance.OnDisableDisqueSpwn;
                @enableDisqueSpwn.started += instance.OnEnableDisqueSpwn;
                @enableDisqueSpwn.performed += instance.OnEnableDisqueSpwn;
                @enableDisqueSpwn.canceled += instance.OnEnableDisqueSpwn;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
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
    private readonly InputAction m_player2_stopMusic;
    private readonly InputAction m_player2_playMusic;
    private readonly InputAction m_player2_removeSpeed;
    private readonly InputAction m_player2_maxSpeed;
    private readonly InputAction m_player2_maxHealth;
    private readonly InputAction m_player2_removeHealth;
    private readonly InputAction m_player2_timeScale0;
    private readonly InputAction m_player2_timeScale1;
    private readonly InputAction m_player2_enableCheatDamage;
    private readonly InputAction m_player2_disableCheatDamage;
    private readonly InputAction m_player2_disableDisqueSpwn;
    private readonly InputAction m_player2_enableDisqueSpwn;
    private readonly InputAction m_player2_Pause;
    private readonly InputAction m_player2_Resume;
    public struct Player2Actions
    {
        private @Controllers m_Wrapper;
        public Player2Actions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_player2_move;
        public InputAction @shoot => m_Wrapper.m_player2_shoot;
        public InputAction @tripleShoot => m_Wrapper.m_player2_tripleShoot;
        public InputAction @stopMusic => m_Wrapper.m_player2_stopMusic;
        public InputAction @playMusic => m_Wrapper.m_player2_playMusic;
        public InputAction @removeSpeed => m_Wrapper.m_player2_removeSpeed;
        public InputAction @maxSpeed => m_Wrapper.m_player2_maxSpeed;
        public InputAction @maxHealth => m_Wrapper.m_player2_maxHealth;
        public InputAction @removeHealth => m_Wrapper.m_player2_removeHealth;
        public InputAction @timeScale0 => m_Wrapper.m_player2_timeScale0;
        public InputAction @timeScale1 => m_Wrapper.m_player2_timeScale1;
        public InputAction @enableCheatDamage => m_Wrapper.m_player2_enableCheatDamage;
        public InputAction @disableCheatDamage => m_Wrapper.m_player2_disableCheatDamage;
        public InputAction @disableDisqueSpwn => m_Wrapper.m_player2_disableDisqueSpwn;
        public InputAction @enableDisqueSpwn => m_Wrapper.m_player2_enableDisqueSpwn;
        public InputAction @Pause => m_Wrapper.m_player2_Pause;
        public InputAction @Resume => m_Wrapper.m_player2_Resume;
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
                @stopMusic.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStopMusic;
                @stopMusic.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStopMusic;
                @stopMusic.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnStopMusic;
                @playMusic.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPlayMusic;
                @playMusic.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPlayMusic;
                @playMusic.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPlayMusic;
                @removeSpeed.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRemoveSpeed;
                @removeSpeed.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRemoveSpeed;
                @removeSpeed.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRemoveSpeed;
                @maxSpeed.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMaxSpeed;
                @maxSpeed.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMaxSpeed;
                @maxSpeed.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMaxSpeed;
                @maxHealth.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMaxHealth;
                @maxHealth.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMaxHealth;
                @maxHealth.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMaxHealth;
                @removeHealth.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRemoveHealth;
                @removeHealth.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRemoveHealth;
                @removeHealth.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRemoveHealth;
                @timeScale0.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale0;
                @timeScale0.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale0;
                @timeScale1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale1;
                @timeScale1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnTimeScale1;
                @enableCheatDamage.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableCheatDamage;
                @enableCheatDamage.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableCheatDamage;
                @disableCheatDamage.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableCheatDamage;
                @disableCheatDamage.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableCheatDamage;
                @disableDisqueSpwn.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableDisqueSpwn;
                @disableDisqueSpwn.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableDisqueSpwn;
                @disableDisqueSpwn.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDisableDisqueSpwn;
                @enableDisqueSpwn.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableDisqueSpwn;
                @enableDisqueSpwn.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableDisqueSpwn;
                @enableDisqueSpwn.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnEnableDisqueSpwn;
                @Pause.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnPause;
                @Resume.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnResume;
                @Resume.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnResume;
                @Resume.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnResume;
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
                @stopMusic.started += instance.OnStopMusic;
                @stopMusic.performed += instance.OnStopMusic;
                @stopMusic.canceled += instance.OnStopMusic;
                @playMusic.started += instance.OnPlayMusic;
                @playMusic.performed += instance.OnPlayMusic;
                @playMusic.canceled += instance.OnPlayMusic;
                @removeSpeed.started += instance.OnRemoveSpeed;
                @removeSpeed.performed += instance.OnRemoveSpeed;
                @removeSpeed.canceled += instance.OnRemoveSpeed;
                @maxSpeed.started += instance.OnMaxSpeed;
                @maxSpeed.performed += instance.OnMaxSpeed;
                @maxSpeed.canceled += instance.OnMaxSpeed;
                @maxHealth.started += instance.OnMaxHealth;
                @maxHealth.performed += instance.OnMaxHealth;
                @maxHealth.canceled += instance.OnMaxHealth;
                @removeHealth.started += instance.OnRemoveHealth;
                @removeHealth.performed += instance.OnRemoveHealth;
                @removeHealth.canceled += instance.OnRemoveHealth;
                @timeScale0.started += instance.OnTimeScale0;
                @timeScale0.performed += instance.OnTimeScale0;
                @timeScale0.canceled += instance.OnTimeScale0;
                @timeScale1.started += instance.OnTimeScale1;
                @timeScale1.performed += instance.OnTimeScale1;
                @timeScale1.canceled += instance.OnTimeScale1;
                @enableCheatDamage.started += instance.OnEnableCheatDamage;
                @enableCheatDamage.performed += instance.OnEnableCheatDamage;
                @enableCheatDamage.canceled += instance.OnEnableCheatDamage;
                @disableCheatDamage.started += instance.OnDisableCheatDamage;
                @disableCheatDamage.performed += instance.OnDisableCheatDamage;
                @disableCheatDamage.canceled += instance.OnDisableCheatDamage;
                @disableDisqueSpwn.started += instance.OnDisableDisqueSpwn;
                @disableDisqueSpwn.performed += instance.OnDisableDisqueSpwn;
                @disableDisqueSpwn.canceled += instance.OnDisableDisqueSpwn;
                @enableDisqueSpwn.started += instance.OnEnableDisqueSpwn;
                @enableDisqueSpwn.performed += instance.OnEnableDisqueSpwn;
                @enableDisqueSpwn.canceled += instance.OnEnableDisqueSpwn;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Resume.started += instance.OnResume;
                @Resume.performed += instance.OnResume;
                @Resume.canceled += instance.OnResume;
            }
        }
    }
    public Player2Actions @player2 => new Player2Actions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_click;
    public struct UIActions
    {
        private @Controllers m_Wrapper;
        public UIActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @click => m_Wrapper.m_UI_click;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @click.started += instance.OnClick;
                @click.performed += instance.OnClick;
                @click.canceled += instance.OnClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
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
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnDisableCheatDamage(InputAction.CallbackContext context);
        void OnEnableCheatDamage(InputAction.CallbackContext context);
        void OnTimeScale1(InputAction.CallbackContext context);
        void OnTimeScale0(InputAction.CallbackContext context);
        void OnRemoveHealth(InputAction.CallbackContext context);
        void OnMaxHealth(InputAction.CallbackContext context);
        void OnMaxSpeed(InputAction.CallbackContext context);
        void OnRemoveSpeed(InputAction.CallbackContext context);
        void OnEnableDisqueSpwn(InputAction.CallbackContext context);
        void OnDisableDisqueSpwn(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayer1Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTripleShoot(InputAction.CallbackContext context);
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnRemoveSpeed(InputAction.CallbackContext context);
        void OnMaxSpeed(InputAction.CallbackContext context);
        void OnMaxHealth(InputAction.CallbackContext context);
        void OnRemoveHealth(InputAction.CallbackContext context);
        void OnTimeScale0(InputAction.CallbackContext context);
        void OnTimeScale1(InputAction.CallbackContext context);
        void OnEnableCheatDamage(InputAction.CallbackContext context);
        void OnDisableCheatDamage(InputAction.CallbackContext context);
        void OnDisableDisqueSpwn(InputAction.CallbackContext context);
        void OnEnableDisqueSpwn(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTripleShoot(InputAction.CallbackContext context);
        void OnStopMusic(InputAction.CallbackContext context);
        void OnPlayMusic(InputAction.CallbackContext context);
        void OnRemoveSpeed(InputAction.CallbackContext context);
        void OnMaxSpeed(InputAction.CallbackContext context);
        void OnMaxHealth(InputAction.CallbackContext context);
        void OnRemoveHealth(InputAction.CallbackContext context);
        void OnTimeScale0(InputAction.CallbackContext context);
        void OnTimeScale1(InputAction.CallbackContext context);
        void OnEnableCheatDamage(InputAction.CallbackContext context);
        void OnDisableCheatDamage(InputAction.CallbackContext context);
        void OnDisableDisqueSpwn(InputAction.CallbackContext context);
        void OnEnableDisqueSpwn(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
