using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DataBaseLogistic
{
    class Create
    {
        public static MySqlCommand createClient(MySqlConnection con)
        {
            string createStatement = "create table if not exists Client (" +
                "user_id" + " varchar(20)," +
                "user_pwd" + " varchar(20)," +
                "user_name" + " varchar(20)," +
                "user_email" + " varchar(30)," +
                "user_idNum" + " varchar(30)," +
                "user_addr" + " varchar(30)," +
                "user_phone" + " varchar(20)," +
                "user_account" + " float" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createPlaceOrderList(MySqlConnection con)
        {
            string createStatement = "create table if not exists placeList (" +
                "worker_id" + " varchar(20)," +
                "order_id" + " varchar(20)," +
                "place_time" + " datetime" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createCheckList(MySqlConnection con)
        {
            string createStatement = "create table if not exists checkList (" +
                "worker_id" + " varchar(20)," +
                "order_id" + " varchar(20)," +
                "check_time" + " datetime" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createReceivList(MySqlConnection con)
        {
            string createStatement = "create table if not exists ReceivList (" +
                "worker_id" + " varchar(20)," +
                "order_id" + " varchar(20)," +
                "receive_time" + " datetime" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createEnterList(MySqlConnection con)
        {
            string createStatement = "create table if not exists enterList (" +
                "worker_id" + " varchar(20)," +
                "order_id" + " varchar(20)," +
                "enter_time" + " datetime" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createDistributeList(MySqlConnection con)
        {
            string createStatement = "create table if not exists distributeList (" +
                "worker_id" + " varchar(20)," +
                "order_id" + " varchar(20)," +
                "distribute_time" + " datetime" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createFinishList(MySqlConnection con)
        {
            string createStatement = "create table if not exists finishList (" +
                "worker_id" + " varchar(20)," +
                "order_id" + " varchar(20)," +
                "finish_time" + " datetime" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createWorker(MySqlConnection con)
        {
            string createStatement = "create table if not exists Worker(" +
                "worker_id" + " varchar(20)," +
                "worker_pwd" + " varchar(20)," +
                "worker_name" + " varchar(20)," +
                "worker_birth" + " date," +
                "worker_native" + " varchar(30)," +
                "worker_gender" + " varchar(5)," +
                "worker_occupt" + " varchar(20)," +
                "worker_phone" + " varchar(20)," +
                "worker_admit" + " date" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createCargo(MySqlConnection con)
        {
            string createStatement = "create table if not exists Cargo (" +
                "cargo_id" + " varchar(20)," +
                "cargo_name" + " varchar(20)," +
                "cargo_type" + " varchar(20)," +
                "cargo_volume" + " float," +
                "cargo_weight" + " float" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createOrder(MySqlConnection con)
        {
            string createStatement = "create table if not exists OrderList (" +
                "order_id" + " varchar(20)," +
                "cargo_id" + " varchar(20)," +
                "user_id" + " varchar(20)," +
                "receiver_id" + " varchar(20)," +
                "money_amount" + " float," +
                "placeOrder_time" + " datetime," +
                "checkOrder_time" + " datetime," +
                "receiveCargo_time" + " datetime," +
                "enterWarehouse_time" + " datetime," +
                "distribute_time" +  " datetime," +
                "finish_time" + " datetime," +
                "state" + " varchar(20)" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createWarehouse(MySqlConnection con)
        {
            string createStatement = "create table if not exists Warehouse(" +
                "warehouse_id" + " varchar(20)," +
                "warehouse_volume" + " float," +
                "warehouse_remain" + " float" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createAdmin(MySqlConnection con)
        {
            string createStatement = "create table if not exists Admin (" +
                "admin_id" + " varchar(20)," +
                "admin_pwd" + " varchar(20)," +
                "admin_name" + " varchar(20)" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand createCargoList(MySqlConnection con)
        {
            string createStatement = "create table if not exists CargoList (" +
                "warehouse_id" + " varchar(20)," +
                "cargo_id" + " varchar(20)," +
                "row_id" + " int(10) unsigned not null," +
                "column_id" + " int(10) unsigned not null" +
                ")";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand ProcChangeState(MySqlConnection con)//创建存储过程，用于改变状态
        {
            string createStatement = 
                "create procedure changeStatus(id varchar(20),newState varchar(20)) " +
                "begin " +
                "update orderList set state = newState where id = id ; " +
                "end";
            return new MySqlCommand(createStatement,con);
        }


        public static MySqlCommand ProcAddMoney(MySqlConnection con)
        {
            string createStatement = 
                "create procedure addMoney(id varchar(20),add_money float) " +
                "begin " +
                "update client set user_account = user_account + add_money where user_id =id ; " + 
                "end";
            return new MySqlCommand(createStatement,con);
        }

        public static MySqlCommand ProcChangeAddr(MySqlConnection con)
        {                           
            string createStatement =
                "create procedure changeAddr(id varchar(20),newAddr varchar(20)) " +
                "begin " +
                "update client set user_addr = newAddr where user_id = id ; " +
                "end";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand ProcChangePhone(MySqlConnection con)
        {
            string createStatement =
                "create procedure changePhone(id varchar(20),newPhone varchar(20)) " +
                "begin " +
                "update client set user_phone = newPhone where user_id = id ; " +
                "end";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand ProcChangeEmail(MySqlConnection con)
        {
            string createStatement =
                "create procedure changeEmail(id varchar(20),newEmail varchar(20)) " +
                "begin " +
                "update client set user_email = newEmail where user_id = id ; " +
                "end";
            return new MySqlCommand(createStatement,con);
        }

        public static MySqlCommand TrigCheck(MySqlConnection con)
        {
            string createStatement =
                "create trigger check_trigger after insert on checkList for each row " +
                "begin " +
                "update orderList set state = \"" + "checked" + "\" " +
                "where order_id = new.order_id; " +
                "update orderlist set receiveCargo_time = localtimestamp()  where order_id = new.order_id;" +
                "end";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand TrigReceiv(MySqlConnection con)
        {
            string createStatement =
                "create trigger receiv_trigger after insert on receivList for each row " +
                "begin " +
                "update orderList set state = \"" + "received" + "\"" +
                "where order_id = new.order_id;" + 
                "update orderlist set receiveCargo_time = localtimestamp()  where order_id = new.order_id;"  +
                "delete from checkList where order_id = new.order_id;" + 
                "end";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand TrigEnter(MySqlConnection con)
        {
            string createStatement =
                "create trigger enter_trigger after insert on enterList for each row " +
                "begin " +
                "update orderList set state = \"" + "entered" + "\"" +
                "where order_id = new.order_id;" +
                "update orderlist set enterWarehouse_time = localtimestamp()  where order_id = new.order_id;" +
                "delete from receivList where order_id = new.order_id;" +
                "end";
            return new MySqlCommand(createStatement, con);
        }

        public static MySqlCommand TrigDistribute(MySqlConnection con)
        {
            string createStatement =
                "create trigger distribute_trigger after insert on distributeList for each row " +
                "begin " +
                "update orderList set state = \"" + "distributed" + "\"" +
                "where order_id = new.order_id;" +
                "update orderlist set distribute_time = localtimestamp()  where order_id = new.order_id;" +
                "delete from enterList where order_id = new.order_id;" +
                "end";
            return new MySqlCommand(createStatement,con);
        }

        public static MySqlCommand TrigFinish(MySqlConnection con)
        {
            string createStatement =
                "create trigger finish_trigger after insert on finishList for each row " +
                "begin " +
                "update orderList set state = \"" + "finished" + "\"" +
                "where order_id = new.order_id;" +
                "update orderlist set finish_time = localtimestamp()  where order_id = new.order_id;" +
                "delete from distributeList where order_id = new.order_id;" +
                "end";
            return new MySqlCommand(createStatement, con);
        }
    }
}
