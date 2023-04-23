# 键盘侠 Keymanx API

> 附属项目，用于为键盘侠应用程序提供 API 服务。

环境：
  - Python 3.6.8
  - pip latest
  - MariaDB 5.5.68 *(MySQL 15.1)*

依赖库：
  - FastAPI
  - Uvicorn
  - PyMySQL
  - Pydantic

## 快速开始

克隆该仓库的 server_api 分支到本地目录

```bash
git clone -b server_api https://github.com/dragonjie233/keymanx.git
```

进入克隆后的目录并安装所需依赖库

```bash
pip install -r requirement.txt
```

运行项目

```bash
python main.py
```

执行以上命令后，项目将会运行在 8001 端口，API 文档为 `http://127.0.0.1:8001/`
