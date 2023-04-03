import pymysql


class DB:
    def __init__(self):
        self.__db       = None
        self.__cursor   = None


    def conn_db(self):
        db = pymysql.connect(
            host     = "localhost",
            user     = "root",
            password = "admin233",
            database = "keyman"
        )

        self.__db = db
        self.__cursor = self.__db.cursor(cursor=pymysql.cursors.DictCursor)
    

    def close_db(self):
        self.__cursor.close()
        self.__db.close()

    
    def exec(self, sql, okTxt = "Execution of SQL statement succeeded.", noTxt = "Execution of SQL statement failed."):
        self.conn_db()

        try:
            self.__cursor.execute(sql)
            self.__db.commit()

            status = {
                "status": "success",
                "msg": okTxt,
            }

            if sql.startswith("SELECT"):
                status["data"] = self.__cursor.fetchall()

        except Exception as e:
            self.__db.rollback()

            status = {
                "status": "error",
                "msg": noTxt,
                "why": e.__doc__
            }

        self.close_db()
        return status