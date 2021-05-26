# VRCAvatars3Validator

[JP](#jp) / [EN](#en)

<p id="jp"></p>
VRChat��Avatars3.0�̃A�o�^�[�ŋN�������ȃ~�X���`�F�b�N�ł���Editor�g���ł�

�`�F�b�N���邽�߂̃��[����V�K�ɍ쐬���Ď��R�ɒǉ��ł��܂�

## �g����

### VRCAvatars3Validator��p�E�B���h�E

Unity�㕔���j���[��`VRCAvatars3Validator/Editor`�����p�̃E�B���h�E���J���܂�

1. Avatar�ɃZ�b�g�A�b�v�ς݂�Avatars3.0�̃A�o�^�[��I�����܂�
2. Rules�̌������������[���Ƀ`�F�b�N�����܂�
3. Validate�{�^����������Errors�Ɍ��ʂ��\������܂�
4. Select�������ƑΏۂ̃I�u�W�F�N�g���I������, �\�Ȃ��̂�AutoFix�Œ����܂�

- �A�o�^�[�A�b�v���[�h���Ƀ��[���̌����Ɉ���������ꍇ�̓A�b�v���[�h�����~����āA�{�E�B���h�E���\������܂�

### Project Settings/VRCAvatars3Validator

Unity�㕔���j���[��`Edit> Project Settings> VRCAvatars3Validator`�ŊJ�����Ƃ��ł���ݒ�E�B���h�E�ł�

- **Validate OnUploadAvatar** : �`�F�b�N������邱�ƂŃA�o�^�[�A�b�v���[�h���Ɏ����e�X�g���s���܂�
- **Enable Rules** : �`�F�b�N�������Ă��郋�[���Ō������܂��B�����̃`�F�b�N�̗L���͐�p�E�B���h�E�Ɠ������܂�

## ���[���̒ǉ�

1. ���[���̃e���v���[�g��p���ĐV�K�̃��[���X�N���v�g���쐬����B�ȉ��̂����ꂩ�̕��@�Ńe���v���[�g����쐬�ł��܂�
    - Project�E�B���h�E��`Create> C# VRCAvatars3ValidatorRule`��I������
    - Unity�㕔���j���[����`Assets> Create> C# VRCAvatars3ValidatorRule`��I������
    - Rules�t�H���_�ɂ���`TemplateRule.cs`��`�E�N���b�N> Duplicate`�ŕ�������
2. VRCAvatars3Validator�t�H���_�ɂ���Rules�t�H���_�ɍ쐬�������[���X�N���v�g�������
3. ��p�E�B���h�E���J���Ȃ���

- ���[����ǉ������ۂɂ͂���github�̃��|�W�g����PR����������
<https://github.com/gatosyocora/VRCAvatars3Validator>

## ����ۏ؊�

Unity 2018.4.20f1

## �ˑ��p�b�P�[�W

���̃c�[����Unity�ɃC���X�g�[�����Ďg�p����ۂɂ͈ȉ��̂��̂��C���X�g�[�����Ă�������

- VRCSDK3-AVATAR-xxxx.xx.xx.xx.xx_Public.unitypackage

## ���p�K��

�{�c�[�����g�p���Ĕ����������ɑ΂��āA  
�����gatosyocora�͈�؂̐ӔC�𕉂����˂܂��̂ŁA  
���炩���߂�������������

�{�c�[����MIT���C�Z���X�ŉ^�p����܂�  
�ڂ�����[LICENSE](https://github.com/gatosyocora/VRCAvatars3Validator/blob/master/LICENSE)��������������

## �A����

- Twitter : [@gatosyocora](https://twitter.com/gatosyocora)
- Discord : gatosyocora#9575

---
<p id="en"></p>
Unity Editor extension to detect errors of VRChat avatar

It can add new detection rule.

## How to use

### VRCAvatars3Validator tool window

It open tool window from `VRCAvatars3Validator/Editor` at Unity top menu.

1. select avatar in `Avatar`
2. put a check rules you want to use of `Rules`
3. press `Validate`, show errors
4. press `Select`, select object had error. press `AutoFix`, fix automatically if can fix.

- When upload avatar, show this window if avatar has error by validate.

### VRCAvatars3Validator setting window

It open tool setting window from `Edit> Project Settings> VRCAvatars3Validator` at Unity top menu.

- **Validate OnUploadAvatar** : validate automatically on upload avatar if put a check
- **Enable Rules** : it use rule that put a check in validation.

## Add new rule

1. It duplicate template file and create rule script. You can select way of duplicate.
    - Select `Create> C# VRCAvatars3ValidatorRule` in Project window
    - Select `Assets> Create> C# VRCAvatars3ValidatorRule` at Unity top menu.
    - Duplicate `TemplateRule.cs` file in Rules folder by `Left click> Duplicate`
2. Put new rule script in Rules folder.
3. Reopen tool window.

- Please PR to github repository if add new rule
<https://github.com/gatosyocora/VRCAvatars3Validator>

## Environment

Unity 2018.4.20f1

## Dependence packages

It needs to install those package if use this tool.

- VRCSDK3-AVATAR-xxxx.xx.xx.xx.xx_Public.unitypackage

## Terms of use

The author gatosyocora cannot be held responsible for any problems that may arise from using this tool. 

This tool is MIT License 
It reads [LICENSE](https://github.com/gatosyocora/VRCAvatars3Validator/blob/master/LICENSE) in detail.

## Contact

- Twitter : [@gatosyocora](https://twitter.com/gatosyocora)
- Discord : gatosyocora#9575