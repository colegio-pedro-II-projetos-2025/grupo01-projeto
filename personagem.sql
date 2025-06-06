-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04/06/2025 às 03:25
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `superbattle`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `personagem`
--

CREATE TABLE `personagem` (
  `id_personagem` int(5) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `poder` varchar(20) NOT NULL,
  `idade` int(5) NOT NULL,
  `arma` varchar(50) NOT NULL,
  `power` int(5) NOT NULL,
  `speed` int(5) NOT NULL,
  `durabilidade` int(5) NOT NULL,
  `inteligencia` int(5) NOT NULL,
  `luta` int(2) NOT NULL,
  `descricao` text NOT NULL,
  `universo` enum('DC','MV') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `personagem`
--

INSERT INTO `personagem` (`id_personagem`, `nome`, `poder`, `idade`, `arma`, `power`, `speed`, `durabilidade`, `inteligencia`, `luta`, `descricao`, `universo`) VALUES
(1, 'Batman', 'Intelecto tático, ar', 35, 'Gadgets e cinto de utilidades', 4, 5, 6, 10, 10, 'Detetive genial, estrategista supremo. Usa tecnologia e artes marciais.', 'DC'),
(2, 'Superman', 'Visão de calor, supe', 35, 'Nenhuma', 10, 10, 10, 9, 8, 'Alienígena de Krypton. Símbolo de esperança com força e poderes divinos.', 'DC'),
(3, 'Mulher-Maravilha', 'Força divina, voo, r', 3000, 'Laço da Verdade e Espada', 9, 8, 9, 8, 10, 'Guerreira amazona com laço da verdade e habilidades semidivinas.', 'DC'),
(4, 'Flash', 'Supervelocidade, man', 28, 'Nenhuma', 5, 10, 7, 9, 7, 'Velocista escarlate. Pode ultrapassar o tempo com sua supervelocidade.', 'DC'),
(5, 'Lanterna Verde', 'Criação de objetos c', 32, 'Anel do Poder', 5, 8, 8, 8, 7, 'Usa um anel de poder que cria qualquer coisa que imaginar.', 'DC'),
(6, 'Arqueiro Verde', 'Mira precisa, acroba', 35, 'Arco e flechas variadas', 4, 5, 6, 8, 8, 'Mestre do arco, bilionário justiceiro com senso de justiça afiado.', 'DC'),
(7, 'John Constantine', 'Magia, invocação, ex', 40, 'Livros de magia, amuletos', 2, 3, 5, 10, 4, 'Ocultista sarcástico. Usa magia e conhecimento sobrenatural para vencer.', 'DC'),
(8, 'Cyborg', 'Tecnopatia, força, c', 25, 'Corpo cibernético', 8, 7, 9, 9, 7, 'Meio-humano, meio-máquina. Arsenal tecnológico e mente brilhante.', 'DC'),
(9, 'Robin', 'Acrobacia, investiga', 22, 'Cajado e gadgets', 4, 5, 6, 8, 8, 'Discípulo do Batman. Ágil, inteligente e grande combatente.', 'DC'),
(10, 'Aquaman', 'Hidrocinésia, comuni', 35, 'Tridente de Poseidon', 9, 7, 9, 7, 9, 'Rei de Atlântida. Comanda os mares e possui força sobre-humana.', 'DC'),
(11, 'Shazam', 'Força mágica, manipu', 16, 'Poder dos deuses', 10, 9, 10, 7, 8, 'Jovem que se transforma em campeão mágico com poderes dos deuses.', 'DC'),
(12, 'Senhor Destino', 'Magia, feitiçaria, m', 45, 'Elmo do Destino', 3, 5, 9, 10, 6, 'Mago poderoso com o Elmo do Destino. Controla feitiços e realidades.', 'DC'),
(13, 'Capitão América', 'Força aprimorada, es', 100, 'Escudo vibranium', 5, 6, 7, 7, 10, 'Soldado exemplar com força aprimorada. Simboliza liderança e honra.', 'MV'),
(14, 'Homem de Ferro', 'Gênio bilionário, te', 48, 'Armadura tecnológica', 10, 9, 10, 10, 8, 'Gênio bilionário em uma armadura tecnológica. Sarcástico e estratégico.', 'MV'),
(15, 'Thor', 'Força divina, contro', 1500, 'Mjolnir', 10, 9, 10, 8, 9, 'Deus do Trovão, empunha o martelo Mjolnir. Força divina e domínio climático.', 'MV'),
(16, 'Homem-Aranha', 'Agilidade, sentido a', 18, 'Nenhuma', 7, 8, 7, 8, 8, 'Adolescente com poderes de aranha. Equilibra responsabilidade e juventude.', 'MV'),
(17, 'Hulk', 'Força descomunal', 40, 'Nenhuma', 10, 6, 10, 6, 8, 'Cientista que se transforma em um monstro verde movido à raiva.', 'MV'),
(18, 'Viúva Negra', 'Artes marciais, espi', 35, 'Nenhuma', 4, 6, 7, 9, 10, 'Espiã letal treinada pela KGB. Hábil em combate e infiltração.', 'MV'),
(19, 'Gavião Arqueiro', 'Mira precisa', 38, 'Arco e flechas especiais', 4, 5, 6, 8, 8, 'Arqueiro mestre com precisão quase sobrenatural.', 'MV'),
(20, 'Doutor Estranho', 'Magia, feitiçaria', 42, 'Amuleto de Agamotto', 3, 5, 8, 10, 6, 'Usa magia e artefatos místicos para proteger o multiverso.', 'MV'),
(21, 'Deadpool', 'Regeneração, combate', 38, 'Espadas e pistolas', 5, 6, 10, 6, 9, 'Mercenário imortal com senso de humor caótico e quebra da quarta parede.', 'MV'),
(22, 'Wolverine', 'Regeneração, garras ', 150, 'Garras de adamantium', 5, 5, 10, 7, 9, 'Mutante com fator de cura, garras de adamantium e temperamento feroz.', 'MV'),
(23, 'Ciclope', 'Raios ópticos', 30, 'Nenhuma', 4, 5, 6, 8, 7, 'Líder dos X-Men. Emite raios ópticos incontroláveis.', 'MV'),
(24, 'Jean Grey', 'Telepatia e telecine', 28, 'Nenhuma', 3, 5, 6, 9, 6, 'Mutante poderosa, hospedeira da Força Fênix. Telepata e telecinética.', 'MV'),
(37, 'Coringa', 'Imprevisibilidade, m', 40, 'Nenhuma', 2, 4, 5, 9, 6, 'Psicopata imprevisível. Vilão icônico do Batman, mestre da manipulação.', 'DC'),
(38, 'Charada', 'Gênio dos enigmas', 45, 'Nenhuma', 2, 3, 4, 10, 3, 'Obcecado por enigmas. Desafia a mente de seus oponentes com jogos mentais.', 'DC'),
(39, 'Lex Luthor', 'Gênio bilionário, te', 50, 'Armadura exoesqueleto', 10, 6, 9, 10, 7, 'Gênio bilionário. Rival de Superman com tecnologia e astúcia.', 'DC'),
(40, 'Darkseid', 'Força imensa, energi', 10000, 'Nenhuma', 10, 9, 10, 10, 9, 'Tirano cósmico. Busca a equação anti-vida para dominar tudo.', 'DC'),
(41, 'Sinestro', 'Poder do anel amarel', 800, 'Anel do Poder', 5, 8, 8, 9, 7, 'Ex-Lanterna Verde, usa o medo para controlar com seu anel amarelo.', 'DC'),
(42, 'Brainiac', 'Intelecto supremo, c', 1000, 'Nenhuma', 7, 6, 9, 10, 6, 'Alienígena com inteligência acima da humana. Controla tecnologia.', 'DC'),
(43, 'Zoom (Hunter Zolomon)', 'Velocidade extrema', 35, 'Nenhuma', 5, 10, 7, 8, 7, 'Velocista que manipula o tempo. Um dos inimigos do Flash.', 'DC'),
(44, 'Exterminador (Slade)', 'Força e estratégia', 40, 'Armas variadas', 5, 6, 7, 9, 10, 'Mercenário mortal, um dos maiores combatentes do universo DC.', 'DC'),
(45, 'Parallax', 'Entidade do medo, en', 1000, 'Nenhuma', 10, 9, 10, 10, 9, 'Entidade cósmica do medo. Um dos maiores vilões do universo DC.', 'DC'),
(46, 'Bane', 'Força aumentada, int', 40, 'Nenhuma', 7, 4, 7, 8, 9, 'Vilão que quebrou o Batman. Uso de Veneno para força aumentada.', 'DC'),
(47, 'Lobo', 'Força e resistência ', 1000, 'Nenhuma', 10, 7, 10, 7, 8, 'Caçador de recompensas alienígena indestrutível e brutal.', 'DC'),
(48, 'Ra\'s al Ghul', 'Imortalidade, mestre', 800, 'Nenhuma', 4, 5, 7, 9, 9, 'Líder da Liga dos Assassinos. Usa o poço de Lázaro para imortalidade.', 'DC'),
(49, 'Galactus', 'Devorador de mundos,', 10000, 'Nenhuma', 10, 9, 10, 10, 8, 'Devorador de mundos. Entidade cósmica de poder incalculável.', 'MV'),
(50, 'Thanos', 'Superforça, inteligê', 1000, 'Manopla do Infinito', 10, 8, 10, 9, 9, 'Titã obcecado por equilíbrio universal. Usou a Manopla do Infinito para dizimar vidas.', 'MV'),
(51, 'Venom', 'Simbionte, força e a', 30, 'Nenhuma', 8, 7, 8, 6, 8, 'Simbionte alienígena que se funde com hospedeiros. Começou como inimigo do Homem-Aranha.', 'MV'),
(52, 'Doutor Destino', 'Gênio, magia, tecnol', 45, 'Armadura tecnológica', 6, 6, 8, 10, 7, 'Cientista e feiticeiro. Ditador da Latvéria e rival do Quarteto Fantástico.', 'MV'),
(53, 'Loki', 'Magia, manipulação', 1000, 'Nenhuma', 6, 7, 8, 10, 7, 'Deus da trapaça. Irmão de Thor, alterna entre vilania e anti-heroísmo.', 'MV'),
(54, 'Duende Verde', 'Força, inteligência,', 40, 'Armadura e equipamentos', 5, 6, 6, 9, 7, 'Empresário enlouquecido. Vilão icônico do Homem-Aranha.', 'MV'),
(55, 'Magneto', 'Manipulação magnétic', 80, 'Nenhuma', 5, 5, 8, 10, 7, 'Mutante que manipula o magnetismo. Antagonista dos X-Men.', 'MV'),
(56, 'Kang', 'Viajante do tempo, t', 1000, 'Armadura tecnológica', 5, 6, 7, 10, 7, 'Viajante do tempo que tenta dominar todas as eras.', 'MV'),
(57, 'Ultron', 'Robô com inteligênci', 50, 'Armadura robótica', 8, 7, 9, 10, 8, 'Inteligência artificial criada para proteger a humanidade… exterminando-a.', 'MV'),
(58, 'Dormammu', 'Magia negra, energia', 10000, 'Nenhuma', 10, 9, 10, 10, 9, 'Senhor da Dimensão Negra. Rival místico do Doutor Estranho.', 'MV'),
(59, 'Rei do Crime', 'Habilidades de comba', 45, 'Nenhuma', 5, 4, 6, 8, 7, 'Chefão do crime em Nova York. Inimigo de Demolidor e Homem-Aranha.', 'MV'),
(60, 'Doutor Octopus', 'Gênio e tentáculos m', 50, 'Braços mecânicos', 8, 4, 8, 9, 6, 'Cientista com tentáculos mecânicos. Um dos maiores vilões do Aranha.', 'MV');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `personagem`
--
ALTER TABLE `personagem`
  ADD PRIMARY KEY (`id_personagem`),
  ADD UNIQUE KEY `nome` (`nome`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `personagem`
--
ALTER TABLE `personagem`
  MODIFY `id_personagem` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
