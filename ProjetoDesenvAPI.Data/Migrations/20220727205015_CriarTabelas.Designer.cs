// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoDesenvAPI.Data.Contexto;

namespace ProjetoDesenvAPI.Data.Migrations
{
    [DbContext(typeof(ProjetoDesenvAPIContexto))]
    [Migration("20220727205015_CriarTabelas")]
    partial class CriarTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Pessoa")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("Id_Pessoa");

                    b.ToTable("tb_Endereco");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Ocorrencia", b =>
                {
                    b.Property<int>("IdOcorrencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Processo")
                        .HasColumnType("int");

                    b.Property<string>("NomeOcorrencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroOcorrencia")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOcorrencia");

                    b.HasIndex("Id_Processo");

                    b.ToTable("tb_Ocorrencia");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Ocorrencia")
                        .HasColumnType("int");

                    b.Property<int>("QtdeProcesso")
                        .HasColumnType("int");

                    b.Property<double>("ValorHora")
                        .HasColumnType("float");

                    b.HasKey("IdPagamento");

                    b.HasIndex("Id_Ocorrencia");

                    b.ToTable("tb_Pagamento");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailPessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPessoa");

                    b.ToTable("tb_Pessoa");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Processo", b =>
                {
                    b.Property<int>("IdProcesso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Pessoa")
                        .HasColumnType("int");

                    b.Property<string>("NomeProcesso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroProcesso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProcesso");

                    b.HasIndex("Id_Pessoa");

                    b.ToTable("tb_Processo");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Endereco", b =>
                {
                    b.HasOne("ProjetoDesenvAPI.Dominio.Dominio.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("Id_Pessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Ocorrencia", b =>
                {
                    b.HasOne("ProjetoDesenvAPI.Dominio.Dominio.Processo", "Processo")
                        .WithMany()
                        .HasForeignKey("Id_Processo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Processo");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Pagamento", b =>
                {
                    b.HasOne("ProjetoDesenvAPI.Dominio.Dominio.Ocorrencia", "Ocorrencia")
                        .WithMany()
                        .HasForeignKey("Id_Ocorrencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ocorrencia");
                });

            modelBuilder.Entity("ProjetoDesenvAPI.Dominio.Dominio.Processo", b =>
                {
                    b.HasOne("ProjetoDesenvAPI.Dominio.Dominio.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("Id_Pessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
