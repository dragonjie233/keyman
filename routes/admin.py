from fastapi import APIRouter, Depends, HTTPException, Body
from db import DB
from hashlib import md5
from model import adminReqBody


# 身份认证依赖
def auth(req: adminReqBody):
    peer = md5(req.passwd.encode("UTF-8")).hexdigest()
    own  = md5("admin233".encode("UTF-8")).hexdigest()

    if peer != own:
        raise HTTPException(status_code=401, detail="身份认证失败")


router = APIRouter(
    prefix="/api/admin",
    dependencies=[Depends(auth)],
    tags=["后台管理"]
)


@router.post(
    "/new/rank", 
    summary = "新增排名数据", 
    description = "通过该接口，可向服务器数据库新增一条排名数据。请注意使用该接口需要提供**身份认证**的字符串。",
    responses={
        "200": {
            "content": {
                "application/json": {
                    "example": {
                        "status": "success",
                        "msg": "新增排名成功"
                    }
                }
            }
        },
        "401": {
            "content": {
                "application/json": {
                    "example": {
                        "detail": "身份认证失败"
                    }
                }
            }
        }
    }
)
async def new(req: adminReqBody = Body(
    example={
        "clas":"必填，班级名称",
        "name":"必填，姓名",
        "level":"必填，等级",
        "score":"必填，成绩",
        "date":"必填，日期",
        "passwd":"必填，身份认证"
    }
)):
    sql = f"INSERT INTO ranklist (`clas`, `name`, `level`, `score`, `date`) VALUES ('{req.clas}', '{req.name}', '{req.level}', {req.score}, '{req.date}')"
    result = DB().exec(sql, "新增排名成功", "新增排名失败")

    return result