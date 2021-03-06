﻿# CPGenerator 
### 简介
这是一款四则题目生成器，支持：
- 整数四则运算
- 真分数四则运算
- 随机出题
- 在线倒计时答题
- 答案判断与解答
### 文件目录
```
.
├── CPGen
│   ├── CPGen                       
│   │   ├── UIBIN                   存放可执行文件
│   │   ├── AnsForm.Designer.cs     答题界面设计预览
│   │   ├── AnsForm.cs              答题界面
│   │   ├── AnsSystem.Designer.cs   答卷生成
│   │   ├── AnsSystem.cs            题目的条件组合选择界面
│   │   ├── CPGen.csproj            项目文件
│   │   ├── Form1.Designer.cs       主界面设计预览
│   │   ├── Form1.cs                主界面
│   │   ├── IntGen.cs               整数题目生成
│   │   ├── OutputForm.Designer.cs  输出系统界面设计预览
│   │   ├── OutputForm.cs           输出系统界面
│   │   ├── PFGen.cs                真分数题目生成
│   │   └── Program.cs              Main函数            
│   └── CPGen.sln                   
├── Izheng                          分工完成的整数部分
├── PFG                             分工完成的真分数部分
├── LICENSE
├── README.md
├── 测试用例.xlsx
├── .git
├── .gitattributes
└── .gitignore
```
### 运行环境
Windows 10 x64
### 使用方法
在 Windows 10 x64 环境下运行`./CPGen/CPGen/UIBIN/CPGen.exe`。
程序开始界面可以选择：
- 导出试题

选择后将进入生成条件选择界面，在指定生成条件下生成 1000 道试题并保存在同目录下的`.txt`文档中。

可选生成条件有 `整数／真分数／混合题目`、`不带乘方／用 ** 表示乘方／用 ^ 表示乘方`。
- 在线答题

选择后将进入题目条件选择界面，点击进入系统后，将在指定题目条件下生成试题并开始在线答题。

每道题有 20s 作答时间，过时本题不得分并自动进入下一题，窗口下方的文本框将显示答题历史记录，包括题目、正确／错误、正确答案、得分。

解答结束后将弹窗显示总分数。

可选题目条件有`题目数量`、`整数／真分数／混合题目`、`不带乘方／用 ** 表示乘方／用 ^ 表示乘方`。

### 历史版本更新
```
v1.0 初步完成了生成四则运算式的部分  
v2.0 整数四则运算第一阶段结束。  
v2.1 整数四则运算第二阶段结束。（引入乘方）  
v2.2 修改了一些小bug。  
v3.0 添加真分数题目模块。  
v4.0 整合了真分数和整数两部分，并做好了导出试题的UI界面，修复了一些bug  
v5.0 在线答题系统UI完成。  
v5.1 修复了输入可为任意字符的bug  
v5.2 修复了输入可为任意长度的bug，修复了输入为空可以点击确定的bug  
v5.3 调整了随机数值相关的部分。  
``` 
