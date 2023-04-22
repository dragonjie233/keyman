from fastapi import APIRouter, Query
from db import DB

router = APIRouter(
    prefix="/api/proenwords",
    tags=["专业词汇"]
)


@router.get(
    "/",
    summary = "获取专业词汇单词数据", 
    description = "通过该接口，可获取到由同学提供的专业词汇数据。",
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
                                "short_words": "string",
                                "long_words": "string",
                                "trans_cn": "string",
                                "supporter": "string",
                                "type": "string"
                            }
                        ]
                    }
                }
            }
        }
    }
)
async def proenwords(
    # type: str = Query(default="B", description="**词汇类型：**B"),
    limit: str = Query(default=100, description="**限制：**限制数据输出量")
):
    sql = f"SELECT * FROM proenwords WHERE id >= ((SELECT MAX(id) FROM proenwords)-(SELECT MIN(id) FROM proenwords)) * RAND() + (SELECT MIN(id) FROM proenwords) LIMIT {limit}"
    result = DB().exec(sql, "查询成功", "查询失败")

    return result