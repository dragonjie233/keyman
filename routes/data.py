from fastapi import APIRouter, Path, Query
from db import DB


router = APIRouter(
    prefix="/api/data",
    tags=["数据查询"]
)


def select_sql(level, sort, limit, other = None):
    temp1 = "SELECT * FROM ranklist WHERE"
    temp2 = f"`level`='{level}' ORDER BY score {sort} LIMIT {limit}"

    if other:
        return f"{temp1} {other} {temp2}"

    return f"{temp1} {temp2}"


@router.get(
    "/ranklist",
    summary = "获取排名数据", 
    description = "通过该接口，可获取到排名数据。您可通过调整参数进行自定义查询。",
    responses={
        "200": {
            "content": {
                "application/json": {
                    "example": {
                        "status": "success",
                        "msg": "查询成功",
                        "data": [
                            {
                                "id": 0,
                                "clas": "String",
                                "name": "String",
                                "level": "String",
                                "score": 0,
                                "date": "String"
                            }
                        ]
                    }
                }
            }
        }
    }
)
async def ranklist(
    level: str = Query(default="初级", description="**等级：**初级/高级"), 
    sort: str = Query(default="ASC", description="**排序：**ASC(升序)/DESC(降序)"), 
    limit: int = Query(default=20, description="**限制：**限制数据输出量")
):
    sql = select_sql(level, sort, limit)
    result = DB().exec(sql, "查询成功", "查询失败")

    return result


@router.get(
    "/{clas}/ranklist",
    summary = "获取班级排名数据", 
    description = "",
    responses = {
        "200": {
            "content": {
                "application/json": {
                    "example": {
                        "status": "success",
                        "msg": "查询成功",
                        "data": [
                            {
                                "id": 0,
                                "clas": "String",
                                "name": "String",
                                "level": "String",
                                "score": 0,
                                "date": "String"
                            }
                        ]
                    }
                }
            }
        }
    }
)
async def classRanklist(
    clas: str = Path(description="**班级名称**"), 
    level: str = Query(default="初级", description="**等级：**初级/高级"), 
    sort: str = Query(default="ASC", description="**排序：**ASC(升序)/DESC(降序)"), 
    limit: int = Query(default=20, description="**限制：**限制数据输出量")
):
    sql = select_sql(level, sort, limit, f"`clas`='{clas}' AND")
    result = DB().exec(sql, "查询成功", "查询失败")

    return result


@router.get(
    "/{date}/ranklist",
    summary = "获取日期排名数据", 
    description = "",
    responses = {
        "200": {
            "content": {
                "application/json": {
                    "example": {
                        "status": "success",
                        "msg": "查询成功",
                        "data": [
                            {
                                "id": 0,
                                "clas": "String",
                                "name": "String",
                                "level": "String",
                                "score": 0,
                                "date": "String"
                            }
                        ]
                    }
                }
            }
        }
    }
)
async def classRanklist(
    date: str = Path(description="**指定日期**"),
    level: str = Query(default="初级", description="**等级：**初级/高级"), 
    sort: str = Query(default="ASC", description="**排序：**ASC(升序)/DESC(降序)"), 
    limit: int = Query(default=20, description="**限制：**限制数据输出量")
):
    sql = select_sql(level, sort, limit, f"`date`='{date}' AND")
    result = DB().exec(sql, "查询成功", "查询失败")

    return result

@router.get(
    "/{clas}/{date}/ranklist",
    summary = "获取班级和日期排名数据", 
    description = "",
    responses = {
        "200": {
            "content": {
                "application/json": {
                    "example": {
                        "status": "success",
                        "msg": "查询成功",
                        "data": [
                            {
                                "id": 0,
                                "clas": "String",
                                "name": "String",
                                "level": "String",
                                "score": 0,
                                "date": "String"
                            }
                        ]
                    }
                }
            }
        }
    }
)
async def classRanklist(
    clas: str = Path(description="**班级名称**"), 
    date: str = Path(description="**指定日期**"), 
    level: str = Query(default="初级", description="**等级：**初级/高级"), 
    sort: str = Query(default="ASC", description="**排序：**ASC(升序)/DESC(降序)"), 
    limit: int = Query(default=20, description="**限制：**限制数据输出量")
):
    sql = select_sql(level, sort, limit, f"`clas`='{clas}' AND`date`='{date}' AND")
    result = DB().exec(sql, "查询成功", "查询失败")

    return result