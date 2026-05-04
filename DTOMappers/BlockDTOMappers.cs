using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Models;

namespace UniversityManagmentSystem.DTOMappers
{
    public class BlockDTOMappers
    {
        // Create Block DTO Mapper
        public static Block BlockDTOToEntityMapper(BLockRequestDTO blockDTO)
        {
            Block block = new Block();
            block.BlockName = blockDTO.BlockName;
            block.BlockCode = blockDTO.BlockCode;
            block.BlockDescription = blockDTO.BlockDescription;
            block.CampusId = blockDTO.CampusId;
            block.Address = blockDTO.Address;
            block.IsActive = true;
            return block;
        }

        // Edit Block DTO Mapper
        public static Block BlockDTOToEditEntityMapper(Block block, BLockRequestDTO blockDTO)
        {
            block.BlockName = blockDTO.BlockName;
            block.BlockCode = blockDTO.BlockCode;
            block.BlockDescription = blockDTO.BlockDescription;
            block.Address = blockDTO.Address;
            block.CampusId = blockDTO.CampusId;
            block.UpdatedAt = DateTime.Now;
            return block;
        }

        // Block Entity → Response DTO Mapper
        public static BlockResponseDTO EntityToBlockDTO(Block block)
        {
            BlockResponseDTO blockResponseDTO = new BlockResponseDTO();
            blockResponseDTO.Id = block.Id;
            blockResponseDTO.BlockName = block.BlockName;
            blockResponseDTO.BlockCode = block.BlockCode;
            blockResponseDTO.Address = block.Address;
            blockResponseDTO.BlockDescription = block.BlockDescription;
            blockResponseDTO.CampusId = block.CampusId;
            blockResponseDTO.EstablishedIn = block.EstablishedIn;
            blockResponseDTO.IsActive = block.IsActive;
            blockResponseDTO.CreatedAt = block.CreatedAt;
            blockResponseDTO.UpdatedAt = block.UpdatedAt;
            blockResponseDTO.DeletedAt = block.DeletedAt;
            blockResponseDTO.GlobalId = block.GlobalId;
            blockResponseDTO.CreatedBy = block.CreatedBy;
            blockResponseDTO.UpdatedBy = block.UpdatedBy;
            blockResponseDTO.DeletedBy = block.DeletedBy;
            return blockResponseDTO;
        }

        // List of BlockResponseDTO Mapper
        public static List<BlockResponseDTO> EntitiesToBlockDTOs(List<Block> blocks)
        {
            List<BlockResponseDTO> blockResponseDTOs = new List<BlockResponseDTO>();
            foreach (Block block in blocks)
            {
                BlockResponseDTO blockResponseDTO = EntityToBlockDTO(block);
                blockResponseDTOs.Add(blockResponseDTO);
            }
            return blockResponseDTOs;
        }
    }
}
