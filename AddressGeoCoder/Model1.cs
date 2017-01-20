namespace AddressGeoCoder
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

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AgentOutboundComm> AgentOutboundComms { get; set; }
        public virtual DbSet<AgentPackage> AgentPackages { get; set; }
        public virtual DbSet<AgentSchedule> AgentSchedules { get; set; }
        public virtual DbSet<AgentSocial> AgentSocials { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AuditEvent> AuditEvents { get; set; }
        public virtual DbSet<ChargeTransaction> ChargeTransactions { get; set; }
        public virtual DbSet<ChargeTxn> ChargeTxns { get; set; }
        public virtual DbSet<DataHistory> DataHistories { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<LeadScript> LeadScripts { get; set; }
        public virtual DbSet<LeadSource> LeadSources { get; set; }
        public virtual DbSet<LeadTier> LeadTiers { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Lookup> Lookups { get; set; }
        public virtual DbSet<Lookup_Value> Lookup_Value { get; set; }
        public virtual DbSet<MerchantAccount> MerchantAccounts { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Offer> Offers { get; set; }
        public virtual DbSet<OfferDetail> OfferDetails { get; set; }
        public virtual DbSet<OfferFeedback> OfferFeedbacks { get; set; }
        public virtual DbSet<OfferListLoadIntoTheSystemNew2> OfferListLoadIntoTheSystemNew2 { get; set; }
        public virtual DbSet<OfferOutcome> OfferOutcomes { get; set; }
        public virtual DbSet<OfferPadOffer> OfferPadOffers { get; set; }
        public virtual DbSet<OffersToImport20170114> OffersToImport20170114 { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<OwnerProperty> OwnerProperties { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<PaymentProcessor> PaymentProcessors { get; set; }
        public virtual DbSet<Privilege> Privileges { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<roleprivilege> roleprivileges { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<StatusHistory> StatusHistories { get; set; }
        public virtual DbSet<SystemValue> SystemValues { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TemplateAtt> TemplateAtts { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<WAFdbLog> WAFdbLogs { get; set; }
        public virtual DbSet<OfferListCool> OfferListCools { get; set; }
        public virtual DbSet<TermsOfUse> TermsOfUses { get; set; }
        public virtual DbSet<TermsOfUseLogin> TermsOfUseLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Agent>()
                .Property(e => e.Login_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Authentication)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.NamePrefix)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.MiddleInitial)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.NameSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.OrderedName)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Cell)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.JobTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.LicenseID)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.AgentBio)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Company)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CenterPointAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CenterPointAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CenterPointCity)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CenterPointState)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CenterPointRegion)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .Property(e => e.CenterPointZip)
                .IsUnicode(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentOutboundComms)
                .WithOptional(e => e.Agent1)
                .HasForeignKey(e => e.Agent);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentPackages)
                .WithRequired(e => e.Agent1)
                .HasForeignKey(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentSchedules)
                .WithRequired(e => e.Agent1)
                .HasForeignKey(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.AgentSpecialties)
                .WithRequired(e => e.Agent1)
                .HasForeignKey(e => e.Agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Agent>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Agent1)
                .HasForeignKey(e => e.Agent);

            modelBuilder.Entity<AgentOutboundComm>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<AgentPackage>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<AgentPackage>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AgentPackage>()
                .Property(e => e.BillingCycle)
                .IsUnicode(false);

            modelBuilder.Entity<AgentSchedule>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<AgentSchedule>()
                .Property(e => e.SchDay)
                .IsUnicode(false);

            modelBuilder.Entity<AgentSocial>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<AgentSocial>()
                .Property(e => e.SocialType)
                .IsUnicode(false);

            modelBuilder.Entity<AgentSocial>()
                .Property(e => e.SocialLink)
                .IsUnicode(false);

            modelBuilder.Entity<Audit>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Audit>()
                .Property(e => e.IPAddr)
                .IsUnicode(false);

            modelBuilder.Entity<AuditEvent>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<AuditEvent>()
                .Property(e => e.IPAddr)
                .IsUnicode(false);

            modelBuilder.Entity<AuditEvent>()
                .Property(e => e.Table_Name)
                .IsUnicode(false);

            modelBuilder.Entity<AuditEvent>()
                .Property(e => e.AuditEventType)
                .IsUnicode(false);

            modelBuilder.Entity<AuditEvent>()
                .Property(e => e.AuditEventComment)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTransaction>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ChargeTxnType)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ReferenceNoInternal)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ChargeTxnID)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.OriginChargeTxnID)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.SubTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.PatientFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.PatientLastName)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.PatientFullName)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCLastName)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCFullName)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCType)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCIIN)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCFinalDigits)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCExpMonth)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.CCExpYear)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ChargeTxnStatus)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.AuthCode)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.AvsCode)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ErrorCode)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ErrorMessage)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.ClientIP)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeTxn>()
                .Property(e => e.Response)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.Property)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.InitialValue)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.GivenValue)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.FKTable)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.FKPrimaryKey)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.FKDisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.PublicIP)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.InternalIP)
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.Action)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DataHistory>()
                .Property(e => e.ForeignTable)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Lead>()
                .Property(e => e.LeadType)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.DispatchNote)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.LeadPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Lead>()
                .Property(e => e.CRMAgent)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.IsOwnerLookingToList)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.MoveDestination)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.IsListed)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.WantReviewFinancingOptions)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .Property(e => e.AnyConstructionNeeds)
                .IsUnicode(false);

            modelBuilder.Entity<Lead>()
                .HasMany(e => e.AgentOutboundComms)
                .WithOptional(e => e.Lead1)
                .HasForeignKey(e => e.Lead);

            modelBuilder.Entity<Lead>()
                .HasMany(e => e.Offers)
                .WithOptional(e => e.Lead1)
                .HasForeignKey(e => e.Lead);

            modelBuilder.Entity<LeadScript>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<LeadScript>()
                .Property(e => e.Question)
                .IsUnicode(false);

            modelBuilder.Entity<LeadScript>()
                .Property(e => e.Answer)
                .IsUnicode(false);

            modelBuilder.Entity<LeadSource>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<LeadSource>()
                .Property(e => e.SourceName)
                .IsUnicode(false);

            modelBuilder.Entity<LeadSource>()
                .Property(e => e.CostperLead)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadTier>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<LeadTier>()
                .Property(e => e.TierName)
                .IsUnicode(false);

            modelBuilder.Entity<LeadTier>()
                .Property(e => e.LeadPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LeadTier>()
                .HasMany(e => e.Leads)
                .WithOptional(e => e.LeadTier1)
                .HasForeignKey(e => e.LeadTier);

            modelBuilder.Entity<Login>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Login>()
                .Property(e => e.Login_ID)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Authentication)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.NamePrefix)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.MiddleInitial)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.NameSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.OrderedName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.SecretQ)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.SecretA)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.LastAuthentication)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.LastAuthentication2)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.DefaultDashboard)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.DefaultLoanStage)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.DefaultApplicantStage)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .HasMany(e => e.Agents)
                .WithOptional(e => e.Login1)
                .HasForeignKey(e => e.Login);

            modelBuilder.Entity<Lookup>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Lookup>()
                .Property(e => e.Attribute)
                .IsUnicode(false);

            modelBuilder.Entity<Lookup>()
                .HasMany(e => e.Lookup_Value)
                .WithRequired(e => e.Lookup1)
                .HasForeignKey(e => e.Lookup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lookup_Value>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Lookup_Value>()
                .Property(e => e.Code_Value)
                .IsUnicode(false);

            modelBuilder.Entity<MerchantAccount>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<MerchantAccount>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<MerchantAccount>()
                .Property(e => e.AccountDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MerchantAccount>()
                .Property(e => e.LoginID)
                .IsUnicode(false);

            modelBuilder.Entity<MerchantAccount>()
                .Property(e => e.LoginPassword)
                .IsUnicode(false);

            modelBuilder.Entity<MerchantAccount>()
                .Property(e => e.BuyPassID)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Note>()
                .Property(e => e.Table_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.Notation)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.AttachedFile)
                .IsUnicode(false);

            modelBuilder.Entity<Offer>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Offer>()
                .Property(e => e.OfferType)
                .IsUnicode(false);

            modelBuilder.Entity<Offer>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Offer>()
                .Property(e => e.DeclineReason)
                .IsUnicode(false);

            modelBuilder.Entity<Offer>()
                .Property(e => e.AdditionalNote)
                .IsUnicode(false);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.OfferDetails)
                .WithRequired(e => e.Offer1)
                .HasForeignKey(e => e.Offer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.OfferFeedbacks)
                .WithOptional(e => e.Offer1)
                .HasForeignKey(e => e.Offer);

            modelBuilder.Entity<Offer>()
                .HasMany(e => e.OfferOutcomes)
                .WithOptional(e => e.Offer1)
                .HasForeignKey(e => e.Offer);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.OrderedName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Cell)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.PropertyType)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Combo)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.SQFT)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Beds)
                .HasPrecision(4, 1);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.Baths)
                .HasPrecision(4, 1);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.LotSize)
                .HasPrecision(9, 2);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.EstValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.LeadType)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.LeadStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.DispatchNote)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.MoveDestination)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.IsOwnerLookingToList)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.IsListed)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.WantReviewFinancingOptions)
                .IsUnicode(false);

            modelBuilder.Entity<OfferDetail>()
                .Property(e => e.AnyConstructionNeeds)
                .IsUnicode(false);

            modelBuilder.Entity<OfferFeedback>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<OfferFeedback>()
                .Property(e => e.AnyNewDevelopment)
                .IsUnicode(false);

            modelBuilder.Entity<OfferFeedback>()
                .Property(e => e.RemindLater)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.Cell)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.CenterPointAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.CenterPointAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.CenterPointCity)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.CenterPointState)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.CenterPointRegion)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.CenterPointZip)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferListLoadIntoTheSystemNew2>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferOutcome>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<OfferOutcome>()
                .Property(e => e.DidMeetWithClient)
                .IsUnicode(false);

            modelBuilder.Entity<OfferOutcome>()
                .Property(e => e.DidPresentToClient)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.CenterPointAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.CenterPointAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.CenterPointCity)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.CenterPointState)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.CenterPointRegion)
                .IsUnicode(false);

            modelBuilder.Entity<OfferPadOffer>()
                .Property(e => e.CenterPointZip)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<OffersToImport20170114>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Owner>()
                .Property(e => e.TrustName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.NamePrefix)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.MiddleInitial)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.NameSuffix)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.OrderedName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.Cell)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .HasMany(e => e.Leads)
                .WithOptional(e => e.Owner1)
                .HasForeignKey(e => e.Owner);

            modelBuilder.Entity<OwnerProperty>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<OwnerProperty>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Package>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Package>()
                .Property(e => e.PackageName)
                .IsUnicode(false);

            modelBuilder.Entity<Package>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Package>()
                .Property(e => e.BillingCycle)
                .IsUnicode(false);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.AgentPackages)
                .WithRequired(e => e.Package1)
                .HasForeignKey(e => e.Package)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.CustServicePhone)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.PaymentProcessingMethod)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.TestLoginId)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.TestLoginPassword)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.RedirectURL)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.XmlURL)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.SoapURL)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.TestRedirectURL)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.TestXMLUrl)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentProcessor>()
                .Property(e => e.TestSoapURL)
                .IsUnicode(false);

            modelBuilder.Entity<Privilege>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Privilege>()
                .Property(e => e.Privilege_id)
                .IsUnicode(false);

            modelBuilder.Entity<Privilege>()
                .Property(e => e.Privilege_description)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Property>()
                .Property(e => e.PropertyType)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.PropertyName)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.AddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.AddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.Zip)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.SQFT)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Property>()
                .Property(e => e.Beds)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Property>()
                .Property(e => e.Baths)
                .HasPrecision(4, 1);

            modelBuilder.Entity<Property>()
                .Property(e => e.LotSize)
                .HasPrecision(9, 2);

            modelBuilder.Entity<Property>()
                .Property(e => e.Combo)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .Property(e => e.EstValue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Property>()
                .Property(e => e.Region)
                .IsUnicode(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.Leads)
                .WithOptional(e => e.Property1)
                .HasForeignKey(e => e.Property);

            modelBuilder.Entity<Role>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .Property(e => e.Role_name)
                .IsUnicode(false);

            modelBuilder.Entity<roleprivilege>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Specialty>()
                .HasMany(e => e.AgentSpecialties)
                .WithRequired(e => e.Specialty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusHistory>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<StatusHistory>()
                .Property(e => e.Table_Name)
                .IsUnicode(false);

            modelBuilder.Entity<StatusHistory>()
                .Property(e => e.OldStatus)
                .IsUnicode(false);

            modelBuilder.Entity<StatusHistory>()
                .Property(e => e.NewStatus)
                .IsUnicode(false);

            modelBuilder.Entity<SystemValue>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Template>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<Template>()
                .Property(e => e.TemplateName)
                .IsUnicode(false);

            modelBuilder.Entity<Template>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<Template>()
                .Property(e => e.Body)
                .IsUnicode(false);

            modelBuilder.Entity<TemplateAtt>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<TemplateAtt>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<TemplateAtt>()
                .Property(e => e.FileLink)
                .IsUnicode(false);

            modelBuilder.Entity<WAFdbLog>()
                .Property(e => e.Login_ID)
                .IsUnicode(false);

            modelBuilder.Entity<TermsOfUse>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<TermsOfUseLogin>()
                .Property(e => e.TSLastModified)
                .IsFixedLength();

            modelBuilder.Entity<TermsOfUseLogin>()
                .Property(e => e.IPAddr)
                .IsUnicode(false);
        }
    }
}
