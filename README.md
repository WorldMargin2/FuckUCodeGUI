# FuckUCodeGUI

[![GitHub stars](https://img.shields.io/github/stars/WorldMargin2/FuckUCodeGUI.svg?style=social&label=Star)](https://github.com/WorldMargin2/FuckUCodeGUI)
[![GitHub forks](https://img.shields.io/github/forks/WorldMargin2/FuckUCodeGUI.svg?style=social&label=Fork)](https://github.com/WorldMargin2/FuckUCodeGUI)
[![Gitee stars](https://gitee.com/WorldMargin/FuckUCodeGUI/badge/star.svg?theme=dark)](https://gitee.com/WorldMargin/FuckUCodeGUI)
[![Gitee forks](https://gitee.com/WorldMargin/FuckUCodeGUI/badge/fork.svg?theme=dark)](https://gitee.com/WorldMargin/FuckUCodeGUI)

## 项目介绍

FuckUCodeGUI 是对 [Done-0/fuck-u-code](https://github.com/Done-0/fuck-u-code) 项目的图形界面扩展。它提供了一个用户友好的Windows界面，使用户可以轻松地使用fuck-u-code工具分析代码质量，而无需直接操作命令行。

fuck-u-code是一个代码质量分析工具，可以帮助开发者发现代码中的潜在问题、坏味道和不规范的编码实践。通过这个图形界面，您可以更直观地配置分析选项、查看结果并导出报告。

## 功能特点

- 🖥️ 直观的图形界面，无需命令行操作
- 📁 支持拖拽文件和目录到界面
- ⚙️ 可配置多种分析参数：
  - 显示详细报告或仅显示总结
  - 输出Markdown格式报告
  - 设置最烂的前N个文件
  - 设置每文件显示的问题数量
  - 排除特定目录或文件
  - 跳过index.js/ts文件
  - 多语言支持（中文、英文、俄文等）
- 📊 结果展示区域，支持双击查看详细内容
- 🔧 可选择在命令行窗口中执行分析

## 安装说明

### 前提条件

1. Windows操作系统
2. .NET Framework（项目使用的版本）
3. [fuck-u-code](https://github.com/Done-0/fuck-u-code) 可执行文件

### 安装步骤

1. 从GitHub或Gitee下载最新版本的FuckUCodeGUI
2. 解压到任意目录
3. 从[fuck-u-code项目](https://github.com/Done-0/fuck-u-code/releases)下载对应版本的可执行文件
4. 运行FuckUCodeGUI.exe

## 使用方法

1. 启动应用程序
2. 点击"..."按钮或直接拖拽fuck-u-code.exe到"FuckUCode 主程序"输入框
3. 选择要分析的代码目录
4. 根据需要配置分析选项
5. 点击"开始分析"按钮
6. 查看分析结果，双击结果区域可查看详细内容

## 许可证

本项目采用 [MIT 许可证](LICENSE.txt)。

## 贡献

欢迎提交Issue和Pull Request来帮助改进这个项目。

## 贡献者

感谢所有为这个项目做出贡献的开发者！

<a href="https://github.com/WorldMargin2/FuckUCodeGUI/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=WorldMargin2/FuckUCodeGUI" />
</a>

## 致谢

- [Done-0/fuck-u-code](https://github.com/Done-0/fuck-u-code) - 核心代码分析工具
