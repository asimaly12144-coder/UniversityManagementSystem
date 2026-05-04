using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Interfaces;
using UniversityManagmentSystem.Models;
using UniversityManagmentSystem.DTOMappers;

namespace UniversityManagmentSystem.Services
{
    public class BlockServices
    {
        private readonly IBlockRepository _blockRepository;

        public BlockServices(IBlockRepository blockRepository)
        {
            _blockRepository = blockRepository;
        }

        public Block AddBlock(BLockRequestDTO request)
        {
            Block block = BlockDTOMappers.BlockDTOToEntityMapper(request);
            block.CreatedAt = DateTime.Now;
            _blockRepository.Add(block);
            _blockRepository.Save();
            return block;
        }

        public List<BlockResponseDTO> GetAll()
        {
            List<Block> blocks = _blockRepository.GetAll().ToList();
            return BlockDTOMappers.EntitiesToBlockDTOs(blocks);
        }

        public bool RemoveBlock(int? id)
        {
            Block block = _blockRepository.Get(b => b.Id == id);
            _blockRepository.Remove(block);
            _blockRepository.Save();
            return true;
        }
    }
}
