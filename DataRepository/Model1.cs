namespace DataRepository
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<MaintainRecord> MaintainRecord { get; set; }
 
        public virtual DbSet<t_rm_saleflow> t_rm_saleflow { get; set; }
  
        public virtual DbSet<t_rm_saleman> t_rm_saleman { get; set; }
 
     
        public virtual DbSet<t_rm_vip_acclist> t_rm_vip_acclist { get; set; }

        public virtual DbSet<t_rm_vip_info> t_rm_vip_info { get; set; }
       
        public virtual DbSet<t_rm_vip_item> t_rm_vip_item { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_rm_saleflow>()
               .Property(e => e.com_no)
               .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.flow_id)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.flow_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.item_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.source_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.cost_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_qnty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_money)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sell_way)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_man)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.shift_no)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.spec_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.pref_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.in_price)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.acc_num)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.dec_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.clss_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.Brand_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.sale_duty_rate)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.plan_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.serials_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.gift_msg)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.visit_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.jc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.jc_qty)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleflow>()
                .Property(e => e.ret_qty)
                .HasPrecision(16, 4);



            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.return_rate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_duty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_saleman>()
                .Property(e => e.sale_duty_rate)
                .HasPrecision(5, 4);



            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.flow_id)
                .HasPrecision(16, 0);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.oper_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.flow_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.new_cardno)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.oper_des)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_acclist>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);



            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_no)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_name)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_sex)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_add)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_zip)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_tel)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_email)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_tax)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.card_status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.oper_id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.social_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.save_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.residual_amt)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.consum_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.duty)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.degree)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.mobile)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.homeplace)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.reg_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.live_place)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.marriage)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.salary_level)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.nation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.height)
                .HasPrecision(3, 0);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.weight)
                .HasPrecision(4, 1);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.blood_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.favor)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.now_acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.acc_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.dec_num)
                .HasPrecision(10, 2);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.com_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.photo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.father_card)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.item_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.branch_no)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.source_card_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_add1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_add2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property1)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property2)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property3)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property4)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property5)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property6)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property7)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property8)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property9)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.annex_property10)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.picture_type)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.bth_flag)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_credentials)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_work)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_intent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.pur_hobbies)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.characteristics)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_trade)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.vip_rem)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.oper_id_make)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.oper_id_gi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.is_makecard)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.IsAlive)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.send_amt)
                .HasPrecision(16, 4);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.modify_oper_id)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_info>()
                .Property(e => e.openid)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_item>()
                        .Property(e => e.item_no)
                        .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_item>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<t_rm_vip_item>()
                .Property(e => e.draw_status)
                .IsFixedLength()
                .IsUnicode(false);
        }
     
    }
}
