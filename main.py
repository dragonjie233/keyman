from fastapi import FastAPI
from fastapi.staticfiles import StaticFiles
from routes import admin, data, proenwords
import uvicorn

app = FastAPI(
    docs_url="/",
    title="Keyman API",
    version="0.1",
    description="键盘侠（keyman）应用程序服务端 API 文档。"
)

# app.mount("/static", StaticFiles(directory="./static"), name="static")
# app.openapi_url = "/static/openapi.json"

app.include_router(admin.router)
app.include_router(data.router)
app.include_router(proenwords.router)


if __name__ == "__main__":
    uvicorn.run("main:app", host="0.0.0.0", port=8001)
    # uvicorn.run("main:app", host="0.0.0.0", port=8001, reload=True)