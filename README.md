# Sistema Liga Tabajara de Futebol  

Um software web desenvolvido com ASP.NET MVC e Entity Framework, criado para facilitar a administração de uma liga de futebol. Oferece recursos para gerenciar times, jogadores, comissão técnica e partidas, além de acompanhar estatísticas e classificação do campeonato, similar ao formato Brasileirão.

---

## Recursos e Funcionalidades  

### **Gestão de Times**
- Adicione, edite, visualize ou exclua informações dos times, incluindo dados como nome, cidade, estado, estádio, capacidade e cores do uniforme.
- Validação automática do status do time (apto ou não), baseada em:
  - Pelo menos 30 jogadores cadastrados.
  - Presença obrigatória de posições essenciais.
  - Comissão técnica com pelo menos 5 membros e cargos únicos.
- Filtros para busca por nome e estádio.

### **Gerenciamento de Jogadores**
- Cadastro completo de jogadores, incluindo informações detalhadas como posição, número, altura, peso e pé dominante (com enum `PePreferido`).
- Filtros de pesquisa por posição (enum `Posicao`), pé preferido ou nome.
- Interface de listagem com estilo inspirado em tabelas esportivas.

### **Comissão Técnica**
- CRUD para membros da comissão técnica, com validação para evitar cargos duplicados (usando enum `Cargo`) em um mesmo time.
- Busca personalizada por nome ou cargo.
- Visual consistente com as outras tabelas do sistema.

### **Partidas e Calendário**
- Gere um novo calendário de partidas com o botão **"Gerar Calendário"** (reseta a liga e cria até 38 rodadas no formato turno e returno entre 20 times).
  - Garantia de que todos os times jogarão como mandantes e visitantes.
  - Datas organizadas semanalmente.
- Interface para registro de placares, incluindo número de gols por jogador (relacionados à entidade `Gol`).
- **Simulação rápida:** Use o botão **"Simular Liga"** para gerar resultados aleatórios de todas as partidas.
- Estatísticas de jogadores atualizadas automaticamente após cada partida.

### **Classificação da Liga**
- Tabela classificatória com cálculos automáticos de pontos, vitórias, empates, derrotas, gols marcados/sofridos e saldo de gols.
- Ordenação por pontos e saldo, com destaque visual para:
  - **Zona Libertadores:** 4 primeiros colocados.
  - **Zona de Rebaixamento:** 4 últimos colocados.

### **Artilharia**
- Estatísticas detalhadas de jogadores por rodada, incluindo gols por time (via `GolsController`).
- Ordenação dinâmica por número de gols (do maior ao menor).

### **Página Inicial**
- **Botões-chave:**
  - **"Gerar Calendário":** Reinicia a liga e cria novas partidas (exclui dados existentes).
  - **"Simular Liga":** Preenche automaticamente todos os resultados das partidas.
  - **"Exibir Calendário":** Revela o Calendário da Liga.

### **Design e Estilo**
- Layout responsivo com Bootstrap.
- Tabelas padronizadas com cores, hover, alinhamentos e zebra‑striping.
- Formulários centralizados e botões de ação intuitivos.

---

## Organização do Projeto  

### **Estrutura de Arquivos**
- **Controllers/**  
  `ArtilhariaController`, `CalendarController`, `ComissaoTecnicasController`, `GolsController`, `HomeController`, `JogadoresController`, `PartidasController`, `SimulacaoController`, `TimesController`  

- **Models/**  
  `Time`, `Jogador` (com enums `Posicao` e `PePreferido`), `ComissaoTecnica` (com enum `Cargo`), `Partida`, `Gol`  

- **Views/**  
  Pastas separadas por controlador, com páginas para ações como exibir, editar e deletar dados.

---

## Passos para Execução  

1. **Pré-Requisitos**  
   - Visual Studio 2019+  
   - .NET Framework 4.7.2+  
   - SQL Server LocalDB ou instância configurada  

2. **Configuração**  
   - Clone o repositório e restaure os pacotes NuGet.  
   - Atualize a string de conexão no `Web.config` se necessário.  

3. **Banco de Dados**  
   - Execute as migrations do Entity Framework para criar/atualizar o banco.  

4. **Execução**  
   - Inicie via IIS Express (F5 ou `Ctrl+F5`).  
   - Use **"Gerar Calendário"** para criar partidas > cadastre times/jogadores > simule ou registre resultados manualmente.  

---

## Dicas para Teste  

1. **Reset do Banco (Opcional):**  
   ```sql
   DELETE FROM Gols;
   DELETE FROM Partidas;
   DELETE FROM ComissaoTecnicas;
   DELETE FROM Jogadors;
   DELETE FROM Times;
   ```
   *Recomendado:* Use **"Gerar Calendário"** no site em vez de executar manualmente.  

2. **Simulação Rápida:**  
   - Após gerar o calendário, clique em **"Simular Liga"** para preencher todos os resultados automaticamente.  


---

**“Liga Tabajara de Futebol” – Controle seu campeonato com eficiência e estilo!**  

--- 


Pronto para usar! 😊
