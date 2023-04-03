from pydantic import BaseModel


# 管理数据路由的请求体模型
class adminReqBody(BaseModel):
    clas:   str = None
    name:   str = None
    level:  str = None
    score:  int = None
    date:   str = None
    passwd: str